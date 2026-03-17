import os
from dotenv import load_dotenv
import asyncio
from auggie_sdk import Auggie

# =============================
# LOAD ENVIRONMENT VARIABLES
# =============================
load_dotenv()

AUGMENT_API_TOKEN = os.getenv("AUGMENT_API_TOKEN")
AUGMENT_API_URL = os.getenv("AUGMENT_API_URL")

if not AUGMENT_API_TOKEN or not AUGMENT_API_URL:
    raise RuntimeError(
        "❌ AUGMENT_API_TOKEN or AUGMENT_API_URL missing in .env"
    )

print("✅ Environment variables found. Token exists:", bool(AUGMENT_API_TOKEN))
print("API URL:", AUGMENT_API_URL)

# =============================
# ASYNC NETWORK TEST
# =============================
async def main():
    agent = Auggie(model="sonnet4.5")  # synchronous init
    try:
        print("⏳ Sending test request to Auggie...")
        # Await the internal run coroutine
        response = await agent.run("Hello world", return_type=str)
        print("✅ Response received:")
        print(response)

    except Exception as e:
        print("❌ Network or token error:", e)

    finally:
        # Proper cleanup to avoid _async_stop warning
        if hasattr(agent, "_async_stop"):
            await agent._async_stop()

# Run the async test
asyncio.run(main())