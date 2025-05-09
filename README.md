# Blazor-Assessment
Translation of provided Figma UI for Blazor Assessment

# Folder Structure

1. `Blazor Assessment`
    - ASP .Net Project
2. `Initial HTML Template`
    - Single HTML page created for reference

# Setup Instructions

## 1. Visual Studio (VS)

**Requirements:**
- Visual Studio 2022 or later
- .NET 8

**Steps:**
1. **Install Prerequisites:**
   - Open Visual Studio Installer.
   - Ensure **ASP.NET and web development** workload is checked.
   - Install the latest **.NET SDK**.

2. **Run the App:**
   - Press **F5** or click **Run/Debug** button.
   - Your app will launch in a browser at `https://localhost:xxxx`.

---

## 2. Visual Studio Code (VS Code)

**Requirements:**
- .NET 8
- VS Code
- C# Extension for VS Code (from Microsoft)

**Steps:**
1. **Install Prerequisites:**
   - Install **.NET SDK** from [dotnet.microsoft.com](https://dotnet.microsoft.com/download).
   - Install **VS Code**.
   - In VS Code, install the **C# extension** from Extensions Marketplace.

2. **Open in VS Code:**
   ```bash
   code .
   ```

4. **Run the App:**
   - Open a terminal in VS Code:
     ```bash
     dotnet run
     ```
   - Open browser and navigate to `https://localhost:5186` (or the port shown).

---

## HTML

Open the HTML file in a browser of your choice


# Approach
Initially, I began the assessment by building the layout using pure HTML and CSS outside the Blazor Server environment. The intent was to establish a responsive UI foundation before integrating Blazor-specific functionality.

# Challenges
This separation created additional complexity when migrating the static layout into .razor components. It led to redundancy and friction in aligning the markup with Blazor's component model, data binding patterns, and event lifecycle. Additionally, restructuring the layout to fit Blazor's MVVC pattern required rewriting and refactoring portions of the initial work.

As a result of these integration delays and duplicated effort, I was unable to complete the full assessment within the allotted time.

# Assumptions
I assumed that isolating the UI from the framework would accelerate the visual design process. However, this overlooked the tight coupling between UI structure and Blazor’s component and routing systems. Integrating directly within the Blazor project from the start would have provided better cohesion and reduced rework.