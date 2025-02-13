// Scenario 5: API Integration
// You can run the code by 'dotnet run' command in terminal.

// Task1: Integrate RESTful API into your application
// Task2: Beautify the output of the API response

async function getObjectData() {
    const url = 'https://api.restful-api.dev/objects/7';
    return 'Sample response';
}

async function main() {
    console.log(await getObjectData());  // Should print the object data from the API
}

main();
