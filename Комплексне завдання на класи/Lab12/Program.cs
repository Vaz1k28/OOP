using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{

    class Task
    {
        public int TaskId { get; set; }
        public string Description { get; set; }

        public Task(int taskId, string description)
        {
            TaskId = taskId;
            Description = description;
        }
    }

    class TaskManager
    {
        private List<Task> tasks;

        public TaskManager()
        {
            tasks = new List<Task>();
        }

        public void AddTask(int taskId, string description)
        {
            Task newTask = new Task(taskId, description);
            tasks.Add(newTask);
            Console.WriteLine($"Task added: {newTask.TaskId} - {newTask.Description}");
        }

        public void RemoveTask(int taskId)
        {
            Task taskToRemove = tasks.Find(task => task.TaskId == taskId);

            if (taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
                Console.WriteLine($"Task removed: {taskToRemove.TaskId} - {taskToRemove.Description}");
            }
            else
            {
                Console.WriteLine($"Task with TaskId {taskId} not found.");
            }
        }

        public void DisplayTasks()
        {
            Console.WriteLine("Tasks:");

            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.TaskId} - {task.Description}");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager();


            taskManager.AddTask(1, "Complete homework");
            taskManager.AddTask(2, "Read a book");

            taskManager.DisplayTasks();

            taskManager.RemoveTask(1);

            taskManager.DisplayTasks();
        }
    }


    //ЗАВДВННЯ 2

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    class UserManager
    {
        private List<User> users;

        public UserManager()
        {
            users = new List<User>();
        }

        public void AddUser(int id, string name)
        {
            User newUser = new User(id, name);
            users.Add(newUser);
            Console.WriteLine($"User added: {newUser.Id} - {newUser.Name}");
        }

        public void RemoveUser(int id)
        {
            User userToRemove = users.Find(user => user.Id == id);

            if (userToRemove != null)
            {
                users.Remove(userToRemove);
                Console.WriteLine($"User removed: {userToRemove.Id} - {userToRemove.Name}");
            }
            else
            {
                Console.WriteLine($"User with Id {id} not found.");
            }
        }

        public void DisplayUsers()
        {
            Console.WriteLine("Users:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Id} - {user.Name}");
            }
        }

        public string GetUserInfo(int id)
        {
            User user = users.Find(u => u.Id == id);
            return user != null ? $"{user.Id} - {user.Name}" : $"User with Id {id} not found.";
        }
    }

    class Program
    {
        static void Main()
        {
            UserManager userManager = new UserManager();

            userManager.AddUser(1, "John Doe");
            userManager.AddUser(2, "Jane Doe");

            userManager.DisplayUsers();

            userManager.RemoveUser(1);

            userManager.DisplayUsers();

            Console.WriteLine("\nUser Information:");
            Console.WriteLine(userManager.GetUserInfo(2));
        }
    }
}
