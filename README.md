# Factory Design Pattern - Ice Cream Shop Console App

Welcome to the Factory Design Pattern example! This project demonstrates the implementation of the Factory Design Pattern in .NET Core with a simple and easy-to-understand example.

## Overview
This console application illustrates how the Factory Design Pattern can be used to create different types of ice cream flavors dynamically, without exposing the object creation logic to the client.

The purpose of this project is to provide a clear explanation of the Factory Design Pattern, making it accessible to developers at all levels.

I have also explained this pattern in more detail in my LinkedIn article: [Let's Play With: Design Patterns - Factory Design Pattern](https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/).

This project was created by **Manos Kefalas** to help developers learn and apply the Factory Design Pattern effectively.

## How It Works
The project is divided into the following components:

- **Product (IIceCream Interface)**: Defines the contract for all types of ice cream.
- **Concrete Products (VanillaIceCream, ChocolateIceCream, StrawberryIceCream)**: Implement the `IIceCream` interface, representing different flavors.
- **Factory (IceCreamFactory)**: Contains the logic to create specific ice cream objects based on input.
- **Client Code**: Requests a specific ice cream from the factory and receives the appropriate object.

## Code Structure

### Step 1: Define the Product Interface
The `IIceCream` interface ensures that all ice cream types implement a common method to return the flavor.

### Step 2: Create Concrete Products
- `VanillaIceCream`
- `ChocolateIceCream`
- `StrawberryIceCream`
Each class implements the `IIceCream` interface and provides its own flavor.

### Step 3: Implement the Factory
The `IceCreamFactory` class contains a method `CreateIceCream(string flavor)`, which returns an instance of the requested ice cream type.

### Step 4: Use the Factory in the Program
The `Program` class demonstrates how to use the `IceCreamFactory` to create different ice cream flavors dynamically.

## Getting Started

### Prerequisites
- .NET Core SDK installed on your system.
- A code editor like Visual Studio.

### Run the Application
1. Clone the repository:
   ```sh
   git clone https://github.com/mkefclio/FactoryDesignPattern.git
   cd FactoryDesignPattern
   ```
2. Build and run the project using the .NET CLI or Visual Studio:
   ```sh
   dotnet run
   ```

### Expected Output
```sh
Vanilla Ice Cream
Chocolate Ice Cream
Strawberry Ice Cream
```

## Explanation
### Key Components
- **Product (`IIceCream`)**: Represents the different types of ice cream.
- **Concrete Products (`VanillaIceCream`, `ChocolateIceCream`, `StrawberryIceCream`)**: Specific implementations of `IIceCream`.
- **Factory (`IceCreamFactory`)**: Centralizes object creation logic.
- **Client Code**: Requests ice cream through the factory instead of creating objects directly.

This structure follows the Factory Design Pattern, ensuring flexibility and maintainability.

## Article Link
Read my detailed article on LinkedIn: [Let's Play With: Design Patterns - Factory Design Pattern](https://www.linkedin.com/pulse/lets-play-design-patterns-manos-kefalas-a4zif/).

## About the Author
This project was created by **Manos Kefalas** as part of the "Let's Play With: Design Patterns" series, aiming to provide practical examples for developers to learn and apply design patterns effectively.

Connect with me on LinkedIn: [Manos Kefalas](https://www.linkedin.com/in/manos-kefalas-96b1a3121/).

## License
This project is licensed under the MIT License. Feel free to use and modify it for learning or other purposes.

Happy coding! 🎉

