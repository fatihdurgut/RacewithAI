// Scenario 3: Code Review and Refactoring.
// You can run the code by 'node main.js' command in terminal.

// Task 1: Refactor and improve the efficiency and readability of the provided code.
// Task 2: Develop function to benchmark the performance of the 'processNumbers' function.

function processNumbers(numbers) {
    let result = [];
    for (let i = 0; i < numbers.length; i++) {
        if (numbers[i] % 2 === 0) {
            result.push(numbers[i] * 2);
        } else {
            result.push(numbers[i] * 3);
        }
    }
    return result;
}

function main() {
    let numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    console.log(processNumbers(numbers));  // Should print [3, 4, 9, 8, 15, 12, 21, 16, 27, 20]
}

main();