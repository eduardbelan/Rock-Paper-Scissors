# Rock - Paper - Scissors: The Game - old starter code
import random
import os
import sys
import time
from art import rock, paper, scissors, logo


# List for form and dict for input check
game_image = [rock, paper, scissors]
valid_input_dict = {
    "1": 0, "r": 0, "rock": 0, "(r)": 0, "stein": 0,
    "2": 1, "p": 1, "paper": 1, "(p)": 1, "papier": 1,
    "3": 2, "s": 2, "scissors": 2, "(s)": 2, "schere": 2
}


def clear_screen():
    """
    Clear the console for Windows or Linux
    """
    # Windows
    clear = lambda: os.system("cls")
    clear()
    # Linux
    # clear = lambda os.system("clear")
    # clear()


def welcome_screen():
    """
    Clear Screen, Print the Logo, Welcome the Player and ask for Player choice
    """
    clear_screen()
    print(logo)
    print("Welcome to the World of Rock, Paper & Scissors.")
    user_input = (input("Type \n"
                        "\t1 for Rock\n"
                        "\t2 for Paper\n"
                        "\t3 for Scissors:\n"))

    input_check(user_input)


def input_check(user_input):
    """
    Check the User Input
    """
    if user_input in valid_input_dict:
        clear_screen()
        print(logo)
        print(f"\nYou choose:\n"
              f"{game_image[valid_input_dict[user_input]]}")
        machine_choice(valid_input_dict[user_input])
    else:
        welcome_screen()


def machine_choice(user_input):
    """
    Machine chooses a form
    """
    machine_input = random.randint(0, 2)

    print(f"\nMachine chooses:\n"
          f"{game_image[machine_input]}")

    outcome(user_input, machine_input)


def outcome(user_input, machine_input):
    """
    Determine the winner, loser or tie
    """
    if user_input == 0 and machine_input == 2:
        print("You win!")
    elif machine_input == 0 and user_input == 2:
        print("You loose!")
    elif machine_input > user_input:
        print("\nYou loose!")
    elif user_input == machine_input:
        print("It's a draw!")
    elif user_input > machine_input:
        print("You win!")


def go_again():
    """
    Ask the User to play
    """
    while True:
        another_one = input("\nPlay? (y/n): ")

        if another_one not in ["y", "n"]:
            print("\nInvalid Input.\n ")
        elif another_one == "n":
            clear_screen()
            sys.exit()
        else:
            welcome_screen()


go_again()
