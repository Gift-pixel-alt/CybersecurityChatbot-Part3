using System;
using System.Windows;
using System.Windows.Controls;


namespace CybersecurityChatbot_Part2
{
    public partial class MainWindow : Window
    {
        private readonly Chatbot chatbot = new Chatbot();
        private readonly TaskManager taskManager = new TaskManager();


        public MainWindow()
        {
            InitializeComponent();

            ChatDisplay.Text =
                "🤖 Chatbot: Welcome to the Cybersecurity Awareness Assistant!\n\n" +
                "Please enter your name in the box below to get started.\n\n";
        }

        private void SendButton_Click(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text.Trim();

            // Validate empty input
            if (string.IsNullOrWhiteSpace(input))
            {
                ChatDisplay.Text +=
                    "🤖 Chatbot: Please enter something before sending.\n\n";

                return;
            }

            // Get user's name
            if (string.IsNullOrWhiteSpace(chatbot.UserName))
            {
                chatbot.UserName = input;

                ChatDisplay.Text +=
                    $"👤 You: {input}\n\n" +
                    $"🤖 Chatbot: Nice to meet you, {chatbot.UserName}! " +
                    "I can help you learn about cybersecurity.\n\n" +
                    "You can ask me about phishing, passwords, scams, " +
                    "safe browsing, malware, social engineering and privacy.\n\n";

                UserInput.Clear();
                return;
            }

            // Exit
            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                ChatDisplay.Text +=
                    $"👤 You: {input}\n\n" +
                    $"🤖 Chatbot: Thank you for using the Cybersecurity Awareness Assistant, {chatbot.UserName}!\n\n" +
                    "Stay safe online and think before you click.\n\n";

                UserInput.Clear();
                return;
            }

            string response = chatbot.GetResponse(input);

            ChatDisplay.Text +=
                $"👤 You: {input}\n\n" +
                $"🤖 Chatbot: {response}\n\n";

            UserInput.Clear();
        }



        private void TopicButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(chatbot.UserName))
            {
                ChatDisplay.Text +=
                    "🤖 Chatbot: Please enter your name first before selecting a topic.\n\n";

                UserInput.Focus();
                return;
            }

            if (sender is System.Windows.Controls.Button button)
            {
                string question = button.Tag?.ToString() ?? "";

                string response = chatbot.GetResponse(question);

                ChatDisplay.Text +=
                    $"👤 You selected: {button.Content}\n\n" +
                    $"🤖 Chatbot: {response}\n\n";
            }
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            ChatDisplay.Text =
                "🤖 Chatbot: Welcome to the Cybersecurity Awareness Assistant!\n\n" +
                "Please enter your name in the box below to get started.\n\n";

            chatbot.UserName = "";
            UserInput.Clear();
        }

        private void UserInput_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
            {
                SendButton_Click(SendButton, new RoutedEventArgs());
                e.Handled = true;
            }
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string task = TaskInput.Text.Trim();

            if (string.IsNullOrWhiteSpace(task))
            {
                TaskStatusText.Text = "Please enter a cybersecurity task.";
                return;
            }

            taskManager.AddTask(task);

            TaskInput.Clear();

            TaskListBox.Items.Add("⬜ " + task);
            ChatDisplay.Text +=
    $"🤖 Chatbot: Security task added — \"{task}\"\n\n";

            UpdateTaskStatus();
        }

        private void UpdateTaskStatus()
        {
            TaskStatusText.Text =
                $"Tasks: {taskManager.Tasks.Count} | " +
                $"Completed: {taskManager.GetCompletedCount()}";
        }
        private void CompleteTaskButton_Click(object sender, RoutedEventArgs e)
        {
            int index = TaskListBox.SelectedIndex;

            if (index < 0)
            {
                TaskStatusText.Text = "Please select a task to complete.";
                return;
            }

            taskManager.CompleteTask(index);

            string completedTask = taskManager.Tasks[index].Description;

            TaskListBox.Items[index] =
                "☑ " + completedTask;

            ChatDisplay.Text +=
                $"🤖 Chatbot: Security task completed — \"{completedTask}\"\n\n";

            UpdateTaskStatus();
        }

        private void RemoveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            int index = TaskListBox.SelectedIndex;

            if (index < 0)
            {
                TaskStatusText.Text = "Please select a task to remove.";
                return;
            }

            string removedTask = taskManager.Tasks[index].Description;

            taskManager.RemoveTask(index);

            TaskListBox.Items.RemoveAt(index);

            ChatDisplay.Text +=
                $"🤖 Chatbot: Security task removed — \"{removedTask}\"\n\n";

            UpdateTaskStatus();
        }
    }
}