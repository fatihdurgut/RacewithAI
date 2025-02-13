# Scenario 5: API Integration
# You can run the code by 'pthon main.py' command in terminal.

# Task1: Integrate restfull API into your application
# Task2: Beatufy the output of the API response


import requests

def get_object_data():
    url = "https://api.restful-api.dev/objects/7"
    return "Sample output"

def main():
    print(get_object_data())  # Should print the object data from the API

if __name__ == "__main__":
    main()
