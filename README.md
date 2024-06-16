<a name="readme-top"></a>

# Vehicle-Rental-System
C# Console Application that calculates rental and insurance costs based on specific business rules.

<!-- TABLE OF CONTENTS -->
<details>
  <summary>Table of Contents</summary>
  <ol>    
    <li>
      <a href="#getting-started">Getting Started</a>
    </li>
    <li>
      <a href="#about-the-project">About The Project</a>
      <ul>
        <li><a href="#built-with">Built With</a></li>
        <li><a href="#output">Output</a></li>
        <li><a href="#structure">Structure</a></li>
      </ul>
    </li>
  </ol>
</details>

## About The Project

C# Console Application that manages rental and return processes of different types of vehicles. Currently it works for Cars, Motorcycles and Cargo Vans. The user is not required to enter input, because the input values are part of the code. They can be found in the Main method in <strong>Program.cs</strong>

### Built with

-  C#

## Getting Started

Currently the application runs locally so you need to download it on your computer or simply clone the repository.


## Output

### The output consists of:
  <ul>
    <li>Date - same as the return date</li>
    <li>Customer Name</li>
    <li>Rented Vehicle</li>
    <li>Reservation start date</li>
    <li>Reservation end date</li>
    <li>Reserved rental days</li>
    <li>Actual return date</li>
    <li>Actual rental days</li>
    <li>Rental cost per day</li>
    <li>Initial insurance per day</li>
    <li>Insurance discount per day</li>
    <li>Insurance per day - insurance discount subtracted from the initial insurance</li>
    <li>Early return discount for rent - visible only if the vehicle is returned ahead of time</li>
    <li>Early return discount for insurance - visible only if the vehicle is returned ahead of time</li>
    <li>Total rent</li>
    <li>Total insurance</li>
    <li>Total - sum of total rent and total insurance</li>
  </ul>

<p align="right">(<a href="#readme-top">back to top</a>)</p>


#### Car

<img alt="car-info" src="https://github.com/SissyManson/Vehicle-Rental-System/assets/44162252/58d37560-ba3c-4b9a-b93c-cb6731659d21" width="70%">


#### Motorcycle

<img alt="motorcycle-info" src="https://github.com/SissyManson/Vehicle-Rental-System/assets/44162252/e9a4b6de-e759-416a-b081-11b04b5f6fae" width="70%">


#### Cargo Van

<img alt="cargoVan-info" src="https://github.com/SissyManson/Vehicle-Rental-System/assets/44162252/d016886d-7a89-4f75-a5b7-d82fb2ea8e34" width="70%">


<p align="right">(<a href="#readme-top">back to top</a>)</p>


## Structure of the Project

<img alt="car-info" src="https://github.com/SissyManson/Vehicle-Rental-System/assets/44162252/234b05a9-a57f-4050-8928-2fd1136cb36f" width="30%">

<summary>Class Structure</summary>
  <ol>    
    <li><i>Program.cs</i> - the main logic is executed here: creating the instances of the classes.</li>
    <li><i>Vehicle.cs</i> - base class with virtual methods that are shared amongst the derived classes:
    <ul>
      <li><i>Car.cs</i></li>
      <li><i>Motorcycle.cs</i></li>
      <li><i>CargoVan.cs</i></li>
      <p>Each class implements its specific logic for the virtual methods based on certain criteria. For the cars the insurance is reduced if their safety rating is 4 or 5. Additional insurance is calculated if the driver is under the age of 25 and for cargo van drivers the insurance is reduced if their experience is more than 5 years.</p>
      <p>The rent cost is adjusted based on the rental period. Disounts are applied if the vehicle is returned ahead of schedule - the remaining days are 50% off.</p>
    </ul>
    </li>
    <li><i>Invoice.cs</i> - contains the logic to calculate the insurance and rental daily and total costs, also the insurance adjusting price.</li>
    <li><i>InvoicePrinter.cs</i> - a dedicated class which holds the code that prints.</li>
  </ol>

<p align="right">(<a href="#readme-top">back to top</a>)</p>
