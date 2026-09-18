# Cybersecurity Awareness Chatbot – Part 3

## Project Overview

The Cybersecurity Awareness Chatbot is a C# WPF desktop application designed to help South African citizens learn about common cybersecurity threats and safer online practices.

Part 3 builds on the graphical user interface developed in Part 2 by adding an advanced interactive **Cybersecurity Task List**. The task list allows users to create practical cybersecurity tasks and track their progress directly inside the application.

The application provides cybersecurity information in a simple and user-friendly way while allowing users to interact with a task management feature.

---

## Part 3 Advanced Feature

### Cybersecurity Task List

The main advanced feature added in Part 3 is a cybersecurity task management system.

Users can:

* Add a cybersecurity task.
* View tasks in a task list.
* Mark a selected task as completed.
* Remove a selected task.
* Clear all tasks.
* View the total number of tasks.
* View the number of completed tasks.
* Receive chatbot activity messages when tasks are added, completed, removed, or cleared.
* Receive validation messages when attempting to perform an invalid task-list action.

### Example Cybersecurity Tasks

Examples of tasks that can be added include:

* Update my phone software.
* Change my Wi-Fi password.
* Enable two-factor authentication.
* Check my email for phishing messages.
* Update my antivirus software.
* Review my privacy settings.

---

## Cybersecurity Topics

The chatbot provides information about several cybersecurity topics, including:

* Phishing
* Password security
* Online scams and fraud
* Safe browsing
* Malware
* Social engineering
* Privacy
* OTP security
* Public Wi-Fi
* Identity theft
* Ransomware
* Online banking security

The chatbot also supports natural-language questions and provides responses based on recognised cybersecurity keywords and topics.

---

## Graphical User Interface

The Part 3 application uses a WPF graphical user interface.

The interface includes:

* Cybersecurity-themed header.
* Welcome message.
* Chat display area.
* User input field.
* SEND button.
* CLEAR button.
* Cybersecurity topic buttons.
* Cybersecurity tips panel.
* Security task management panel.
* Task input field.
* Task list.
* COMPLETE button.
* REMOVE button.
* CLEAR ALL button.
* Task progress counter.

The application also supports pressing **Enter** to send a chatbot message.

---

## Task Management Functions

The task-management system is separated into dedicated C# classes.

### SecurityTask.cs

The `SecurityTask` class represents an individual cybersecurity task.

Each task contains:

* Task description.
* Completion status.

### TaskManager.cs

The `TaskManager` class manages the collection of cybersecurity tasks.

It provides methods for:

* Adding tasks.
* Completing tasks.
* Removing tasks.
* Counting completed tasks.

The task manager also keeps track of the total number of tasks.

---

## Validation

The application includes validation to improve the user experience.

Examples include:

* Preventing empty chatbot messages.
* Requesting the user's name before using topic buttons.
* Preventing empty cybersecurity tasks from being added.
* Informing the user when no task is selected for completion.
* Informing the user when no task is selected for removal.
* Informing the user when there are no tasks to clear.



## Chatbot Interaction

When the application starts, the user is asked to enter their name.

After entering a name, the chatbot provides a personalised welcome message.

The user can then ask questions such as:

> What is phishing?

> How should I protect my password?

> How can I avoid online scams?

> How can I browse safely?

> What is malware?

> How can I protect my privacy?

The topic buttons can also be used to quickly access common cybersecurity topics.


## Technologies Used

* **C#**
* **.NET 10**
* **WPF (Windows Presentation Foundation)**
* **XAML**
* **Visual Studio Code**
* **Git**
* **GitHub**
* **GitHub Actions**





## How to Run the Application

### Requirements

The following software is required:

* Windows operating system.
* .NET 10 SDK.
* Visual Studio Code or another compatible C# development environment.
## Testing Performed

The following functionality was tested during development:

### Chatbot Testing

* Application launches successfully.
* User name can be entered.
* Personalised greeting is displayed.
* Cybersecurity questions receive responses.
* Topic buttons provide cybersecurity information.
* Empty messages are rejected.
* Enter key sends messages.
* CLEAR resets the chatbot session.

### Task List Testing

* Tasks can be added.
* Empty tasks are rejected.
* Tasks appear in the task list.
* Tasks can be marked as completed.
* Completed task count updates correctly.
* Tasks can be removed.
* All tasks can be cleared.
* Task count resets after clearing.
* The application displays an appropriate message when there are no tasks to clear.
* Chat activity messages are displayed when tasks are added, completed, removed, or cleared.






## Future Improvements

Possible future improvements include:

* Saving tasks between application sessions.
* Adding task priorities.
* Adding task due dates.
* Adding cybersecurity reminders.
* Adding progress percentages.
* Adding more cybersecurity topics.
* Adding a cybersecurity awareness quiz.
* Adding a simple cybersecurity game.
* Improving accessibility and visual design.



## Author

**Author:** Tekano Malebana

**Project:** Cybersecurity Awareness Chatbot – Part 3

**Technology:** C# WPF / .NET 10


