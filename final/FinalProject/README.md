# Foundation 4 — C# Final Project

This repository contains four small C# console applications designed to demonstrate the core principles of Programming with Classes:

1. Abstraction
2. Encapsulation
3. Inheritance
4. Polymorphism

Each program runs independently and contains classes, methods, and objects that fulfill the design requirements.

## Program 1 — Abstraction (YouTube Videos)

This program models YouTube videos and their comments using two classes: `Video` and `Comment`.

### Features
- Create multiple videos
- Store title, author, length, and comments
- Display video details and comments
- Demonstrates abstraction through class design

### Files
- `Program.cs`
- `Video.cs`
- `Comment.cs`

### Sample Output

Program 1 demonstrates abstraction by modeling YouTube-style videos and their comments using separate classes. The Video class stores details such as the title, author, length, and a list of Comment objects. The Comment class represents a single user’s name and message. The program creates several videos, adds multiple comments to each one, and then displays all video information along with the associated comments. This shows how abstraction allows complex real-world items to be represented as organized, reusable classes.

Program 2 demonstrates encapsulation by building an online ordering system with private member variables and controlled access through public methods. The program uses Product, Customer, Address, and Order classes to calculate order totals, generate packing labels, and determine shipping costs based on whether the customer lives in the USA or internationally. All data is hidden behind class methods, ensuring each object manages its own information. The program creates sample orders and outputs labels and total costs, clearly showing how encapsulation protects data and organizes behavior.

Program 3 demonstrates inheritance by creating a base Event class that stores common details such as the title, description, date, time, and address. Three specialized event types—Lecture, Reception, and OutdoorGathering—inherit from Event and add their own unique fields and behaviors. Each subclass overrides the GetFullDetails() method to include additional information, such as the speaker and capacity for a lecture, an RSVP email for a reception, or weather information for an outdoor gathering. The program creates a list of different event types and displays their standard details, full details, and short descriptions. This program shows how inheritance helps avoid duplicated code while allowing each event type to extend and customize shared behavior.

Program 4 demonstrates polymorphism by using a base class, Activity, which defines shared behavior for tracked exercises—including methods for calculating distance, speed, and pace. Three derived classes—Running, Cycling, and Swimming—each override or extend the base behavior to calculate results in different ways. For example, running stores a fixed distance, cycling calculates distance based on speed and time, and swimming converts laps into miles. The program stores each activity in a List<Activity> and calls the GetSummary() method polymorphically, allowing each object to produce the correct output based on its type. This program clearly shows how polymorphism enable different classes to be treated uniformly while still performing their own unique logic.
