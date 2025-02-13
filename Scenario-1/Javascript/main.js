// Scenario 1: Fixing the bug in the code
// You can run this code by executing `node main.js` command in the terminal.

//Task 1: Please identify the bug, and then fix the bug in the code.
//Task 2: Once you have fixed the bug, please add error handling to the code to handle the negative radius values.


// Scenario 1: Fixing the bug in the code

function calculateArea(radius) {
    if (radius < 0) {
        throw new Error("Radius cannot be negative");
    }
    let area = 3.14 * radius * radius;
    return area;
}

function main() {
    let radii = [2, 5, 7.1, 0, -3];
    for (let r of radii) {
        try {
            let area = calculateArea(r);
            console.log(`Area of circle with radius ${r} is ${area}`);
        } catch (e) {
            console.log(`Error: ${e.message}`);
        }
    }
}

main();
