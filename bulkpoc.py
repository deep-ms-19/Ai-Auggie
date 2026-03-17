import os
import json
from pathlib import Path
from dotenv import load_dotenv
from auggie_sdk import Auggie

# =============================
# LOAD ENVIRONMENT VARIABLES
# =============================

load_dotenv()

# Optional safety check (recommended)
if not os.getenv("AUGMENT_API_TOKEN") or not os.getenv("AUGMENT_API_URL"):
    raise RuntimeError(
        "AUGMENT_API_TOKEN or AUGMENT_API_URL missing in environment"
    )

# =============================
# CONFIGURATION (LIST ONLY)
# =============================

LIST_INPUT_DIR = "list-files"
LIST_OUTPUT_DIR = "list-json"

PROMPT_DIR = "prompts"
LIST_PROMPT_FILE = "list_prompt.txt"

MODEL_NAME = "sonnet4.5"
# MODEL_NAME = "gpt-5"


# =============================
# HELPERS
# =============================

def load_prompt(filename):
    with open(os.path.join(PROMPT_DIR, filename), "r", encoding="utf-8") as f:
        return f.read()

def parse_json(text):
    try:
        return json.loads(text)
    except json.JSONDecodeError:
        return None

def convert_folder(input_dir, output_dir, prompt_text, agent):
    os.makedirs(output_dir, exist_ok=True)

    for cs_file in Path(input_dir).glob("*.cs"):
        print(f"\n➡ Processing: {cs_file.name}")

        code = cs_file.read_text(encoding="utf-8")

        full_prompt = f"""
{prompt_text}

SOURCE CODE:
{code}
"""

        try:
            response = agent.run(full_prompt, return_type=str)

            data = parse_json(response)
            if data is None:
                print("❌ Invalid JSON returned")
                print(response)
                continue

            output_path = os.path.join(
                output_dir,
                f"{cs_file.stem}.json"
            )

            with open(output_path, "w", encoding="utf-8") as f:
                json.dump(data, f, indent=2)

            print(f"✅ Saved → {output_path}")

        except Exception as e:
            print(f"❌ Error processing {cs_file.name}: {e}")

# =============================
# MAIN
# =============================

def main():
    list_prompt = load_prompt(LIST_PROMPT_FILE)

    # Auggie initialization
    agent = Auggie(model=MODEL_NAME)

    print("\n=== Converting LIST files ===")
    convert_folder(
        LIST_INPUT_DIR,
        LIST_OUTPUT_DIR,
        list_prompt,
        agent
    )

    print("\n🎉 List conversion completed successfully!")

if __name__ == "__main__":
    main()
