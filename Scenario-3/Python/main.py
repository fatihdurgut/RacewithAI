# Scenario 3: Code Review and Refactoring.
# You can run the code by 'pthon main.py' command in terminal.

# Task 1: Refactor and improve the efficiency and readability of the provided code.
# Task 2: Develop function to benchmark the performance of the 'process_numbers' function.

def process_numbers(numbers):
    result = []
    for i in range(len(numbers)):
        if numbers[i] % 2 == 0:
            result.append(numbers[i] * 2)
        else:
            result.append(numbers[i] * 3)
    return result

def main():
    numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
    print(process_numbers(numbers))  # Should print [3, 4, 9, 8, 15, 12, 21, 16, 27, 20]

main()
