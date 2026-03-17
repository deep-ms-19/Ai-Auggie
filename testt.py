import os
import json
from pathlib import Path
from dotenv import load_dotenv
from auggie_sdk import Auggie
import asyncio

# =============================
# LOAD ENVIRONMENT VARIABLES
# =============================

load_dotenv()

if not os.getenv("AUGMENT_API_TOKEN") or not os.getenv("AUGMENT_API_URL"):
    raise RuntimeError(
        "AUGMENT_API_TOKEN or AUGMENT_API_URL missing in environment"
    )

# =============================
# CONFIGURATION (LIST ONLY)
# =============================

BASE_DIR = Path(__file__).resolve().parent

LIST_INPUT_DIR = BASE_DIR / "list-files"
LIST_OUTPUT_DIR = BASE_DIR / "list-json"
PROMPT_DIR = BASE_DIR / "prompts"
LIST_PROMPT_FILE = "list_prompt.txt"

MODEL_NAME = "sonnet4.5"
# MODEL_NAME = "gpt-5"

# =============================
# HELPERS
# =============================

def load_prompt(filename):
    prompt_path = PROMPT_DIR / filename
    if not prompt_path.exists():
        raise FileNotFoundError(f"Prompt file not found: {prompt_path}")
    return prompt_path.read_text(encoding="utf-8")


def parse_json(text):
    try:
        return json.loads(text)
    except json.JSONDecodeError:
        return None


async def convert_folder_async(input_dir, output_dir, prompt_text, agent):
    os.makedirs(output_dir, exist_ok=True)

    cs_files = list(Path(input_dir).glob("*.cs"))
    if not cs_files:
        print(f"⚠️ No .cs files found in {input_dir}")
        return

    for cs_file in cs_files:
        print(f"\n➡ Processing: {cs_file.name}")
        print("Full path:", cs_file.resolve())
        print("Exists:", cs_file.exists())
        if not cs_file.exists():
            print(f"❌ Skipping, file not found: {cs_file}")
            continue

        code = cs_file.read_text(encoding="utf-8")
        full_prompt = f"{prompt_text}\n\nSOURCE CODE:\n{code}"

        try:
            response = await agent.run(full_prompt, return_type=str)

            data = parse_json(response)
            if data is None:
                print("❌ Invalid JSON returned")
                print(response)
                continue

            output_path = output_dir / f"{cs_file.stem}.json"
            with open(output_path, "w", encoding="utf-8") as f:
                json.dump(data, f, indent=2)

            print(f"✅ Saved → {output_path}")

        except Exception as e:
            print(f"❌ Error processing {cs_file.name}: {e}")


# =============================
# MAIN
# =============================

async def main_async():
    list_prompt = load_prompt(LIST_PROMPT_FILE)
    agent = Auggie(model=MODEL_NAME)

    print("\n=== Converting LIST files ===")
    await convert_folder_async(LIST_INPUT_DIR, LIST_OUTPUT_DIR, list_prompt, agent)
    print("\n🎉 List conversion completed successfully!")


if __name__ == "__main__":
    asyncio.run(main_async())