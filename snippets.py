# Rock - Paper - Scissors: The Game - old starter code
import random

rock = ('''
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
''')

paper = ('''
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
''')

scissors = ('''
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
''')

game_image = [rock, paper, scissors]

print("Welcome to the World of Rock, Paper & Scissors.")
print("Are you ready to enjoy one of, if not the greatest experience of your life?")
usr_input_raw = int(input("Type 1 for Rock, 2 for Paper or 3 for Scissors:\n\n"))

usr_input = usr_input_raw - 1

if usr_input >= 3 or usr_input < 0:
    print("Invalid Number!")

else:
    print(f"\nYou choose:\n{game_image[usr_input]}\n\n")

    comp_input = random.randint(0, 2)

    print(f"\nComputer choose:\n{game_image[comp_input]}")

    if usr_input == 0 and comp_input == 2:
        print("You win!")
    elif comp_input == 0 and usr_input == 2:
        print("You loose!")
    elif comp_input > usr_input:
        print("\nYou loose!")
    elif usr_input == comp_input:
        print("It's a draw!")
    elif usr_input > comp_input:
        print("You win!")
    elif usr_input >= 3 or usr_input < 0:
        print("Invalid Number!")
