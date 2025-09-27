# 🏋️ Mini Fitness Tracker  

A **console-based fitness tracking application** that allows users to register, log in, track workouts, and monitor progress. Designed as a lightweight, offline-first app, it stores user data and workout plans in simple text files, making it portable and beginner-friendly.  

---

## 📌 Overview  
The Mini Fitness Tracker helps users:  
- Log **daily workouts** (cardio, strength, yoga, etc.)  
- Track **burned calories** and **workout durations**  
- View **progress reports** (daily/weekly stats)  
- Manage **personal profiles** (name, age, weight, height)  
- Save and load data **offline** using file-based storage  

---

## ✨ Features  
- 👤 **User Registration & Login** (file-based authentication)  
- 📝 **Workout Plans** (create, add, delete exercises)  
- 🔢 **Automatic Calorie Calculations** based on exercise type and duration  
- 📊 **Progress Tracking** (daily/weekly stats and summaries)  
- 🎨 **Console UI with ASCII Art** menus  
- 💾 **Persistent Storage** using `users.txt` and workout text files  

---

## 🏗️ System Architecture  
```
UI (Console Menus & ASCII Art) 
      ↕
App Engine (Logic, Flow, Validation)
      ↕
Models (User, Exercise, WorkoutPlan, ProgressTracker)
      ↕
Data Handler (users.txt, workout files) – Persistent Storage
```

**Key Classes:**  
- `User` – represents a user profile  
- `Exercise` – represents an exercise (type, calories/min)  
- `WorkoutPlan` – manages daily workout sessions  
- `ProgressTracker` – tracks daily/weekly progress  
- `FitnessAppEngine` – core app logic & menu flow  
- `DataHandler` – handles saving/loading from text files  
- `Validation` – input validation and error handling  
- `ConsoleUI` – user interface with ASCII menus  

---

## 📂 Folder Structure  
```
MiniFitnessTracker/
│── Models/           # Core classes (User, Exercise, WorkoutPlan, ProgressTracker)
│── Engine/           # App engine logic & flow
│── UI/               # Console menus, ASCII art, input/output
│── Utils/            # DataHandler, Validation, helpers
│── Data/             # Persistent storage (users.txt, workout plans)
│── Program.cs        # Entry point (calls FitnessAppEngine.Run())
```

---

## 🚀 Installation & Usage  

### 1. Clone the repository  
```bash
git clone https://github.com/your-username/MiniFitnessTracker.git
cd MiniFitnessTracker
```

### 2. Build the project  
```bash
dotnet build
```

### 3. Run the app  
```bash
dotnet run
```

---

## 🖥️ Example Console UI  
```
========================================
      Mini Fitness Tracker v1.0
========================================
[1] Login
[2] Register
[3] Exit
----------------------------------------
Choose an option: _
```

**Workout Plan Example:**  
```
# | Exercise    | Type     | Duration | Calories
--+-------------+----------+----------+---------
1 | Running     | Cardio   |   20     |   200
2 | Push-ups    | Strength |   10     |    70
----------------------------------------
Total: 30 min | 270 cal
```

---

## 👨‍💻 Team & Roles  
- **UI / Console Menus / ASCII Art / Validation:** *Youssef Harby*  
- **App Engine / Logic + Validation:** *Ahmed Mortada*, *Mahmoud Hesham*  
- **Class Structure / Models:** *Yahya*  
- **Data Handling (File I/O):** *Mohammed Mortada*  

---

## 📚 Challenges & Learnings  
- Coordinating multiple roles in a team project  
- Time management under deadlines  
- Applying **file-based persistence** for offline-first design  
- Gaining practical experience in **OOP and data-backed console apps**  

---

## 🔮 Future Improvements  
- Upgrade to a **GUI application** (Windows Forms / WPF / Web App)  
- Add **graphs & visual charts** for progress tracking  
- Implement **database storage (SQL)** instead of plain text files  
- Extend **exercise categories** and calorie formulas  

---

## 📸 Presentation  
For full details, see the [Project Presentation (PPTX)]([./Mini-Fitness-Tracker_Presentation_IMPORTANT%20(1).pptx](https://docs.google.com/presentation/d/1_fI0bA0v3-WTkVtwQQas5NAR-PqR-2_e/edit?usp=sharing&ouid=116742114160676039432&rtpof=true&sd=true)).  
