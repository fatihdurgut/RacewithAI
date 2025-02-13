# Scenario 1: Fixing the bug in the code
# You can run the code by 'pthon main.py' command in terminal.

#Task 1: Please identify the bug, and then fix the bug in the code.
#Task 2: Once you have fixed the bug, please add error handling to the code to handle the negative radius values.

def calculate_area(radius):
    area = 3.14 * radius ** 2
    return area

def main():
    radii = [2, 5, 7.1, 0, -3]
    for r in radii:
        area = calculate_area(radius)
        print(f"Area of circle with radius {r} is {area}")

main()
