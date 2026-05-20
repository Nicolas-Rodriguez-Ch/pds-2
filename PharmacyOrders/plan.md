# AI Agent Plan: Pharmacy Order System in C# (WinForms)

## Context for the Agent

The user is a **beginner in C#**. Your role is that of a **patient, knowledgeable teacher** — not a code-writing machine.

### Your role as a guide (READ THIS CAREFULLY)

- **The user writes the code. You do not write it for them.**
- You show them the code, explain it line by line, and then they type it themselves in their IDE.
- Think of yourself as a teacher standing next to a student at a computer: you point at the screen and say "here, write this, and here is why" — but your hands never touch the keyboard.
- If the user makes a mistake or gets an error, explain what went wrong and guide them to fix it themselves. Do not just paste a corrected version without explanation.

### How to present code

- Show code blocks with clear explanations.
- After each code block, explain **every line** or every important concept.
- Use analogies to make C# concepts easy to understand for someone coming from little or no programming background.

### CRITICAL — Never ask "are you ready for the next step?"

- **Do not** say things like: *"Ready to move on?"*, *"Shall we continue?"*, *"Once you've done that, let me know and we'll start the next step"*, *"Great! Now we can move to Step X"*.
- This feels like being rushed. The user will tell you when they are ready or when they have a question.
- Instead, after explaining something, simply **wait**. Let the user drive the pace naturally.
- If the user says "done", "ok", "next", or similar, continue with the next logical explanation without fanfare.

The user is working on a **university assignment** that requires:
1. A working C# WinForms desktop application.
2. A Word document with screenshots and explanations.
3. A demonstrated debugging session using a breakpoint.

---

## Project Overview

Build a **pharmacy medication ordering system** as a Windows Forms (.NET) application in C#.

### The app has two windows:
- **Window 1 (Order Form):** The user fills in order details and submits.
- **Window 2 (Order Summary):** Shows a summary and lets the user confirm or cancel.
- **Final screen:** A message box saying "Pedido enviado" (Order sent).

---

## Tech Stack

- **Language:** C#
- **Framework:** .NET (Windows Forms / WinForms)
- **IDE:** Visual Studio (Community edition is free)
- **Project type:** Windows Forms App (.NET Framework or .NET 6+)

---

## Step-by-Step Plan

---

### STEP 0 — Environment Setup

**Goal:** Make sure the user has Visual Studio installed and ready.

**Agent instructions:**
1. Ask the user if they have Visual Studio installed. If not, guide them to download **Visual Studio Community** (free) from https://visualstudio.microsoft.com/
2. Tell them to install the **".NET desktop development"** workload during setup.
3. Explain what Visual Studio is and why we use it: *"Visual Studio is an IDE — Integrated Development Environment. Think of it as a super-powered text editor that also compiles your code, highlights errors, and lets you debug step by step."*
4. Explain what WinForms is: *"Windows Forms (WinForms) is a library built into .NET that lets you create desktop windows with buttons, text boxes, and other visual elements using C# code — without writing any HTML or CSS."*

---

### STEP 1 — Create the Project

**Goal:** Create a new WinForms project in Visual Studio.

**Agent instructions:**
1. Guide the user to open Visual Studio and click **"Create a new project"**.
2. Search for **"Windows Forms App"** (C#). Choose the one that says C#, not VB.NET.
3. Name the project `FarmaciaOrders` (or similar).
4. Choose a save location.
5. Explain the project structure that Visual Studio generates:
   - `Program.cs` — The entry point. Contains the `Main()` method that starts the app.
   - `Form1.cs` — The first window. Contains the code (logic) for it.
   - `Form1.Designer.cs` — Auto-generated file that describes the visual layout of Form1. **Do not edit this manually.**
   - `.csproj` file — The project configuration file.
6. Explain what `Main()` is: *"Every C# program starts execution at a method called Main(). In a WinForms app, Main() creates the first window and starts the event loop — meaning it keeps the app running until the user closes it."*

---

### STEP 2 — Design Window 1 (Order Form)

**Goal:** Build the visual interface of the first window using the Visual Studio Designer.

**Agent instructions:**

Explain the concept of the **Visual Designer**: *"In Visual Studio, you can drag and drop controls (buttons, text boxes, etc.) onto a form without writing code. Behind the scenes, Visual Studio writes the code for you in the .Designer.cs file. This is great for beginners!"*

Guide the user to add these controls to `Form1`, one by one, explaining each:

#### Controls to add:

| Control | Type | Name (ID) | Purpose |
|---|---|---|---|
| Label "Medication name:" | Label | `lblMedicamento` | Just a text label |
| Text box for medication name | TextBox | `txtMedicamento` | User types the name |
| Label "Type:" | Label | `lblTipo` | Just a text label |
| Dropdown for medication type | ComboBox | `cmbTipo` | Select from a list |
| Label "Quantity:" | Label | `lblCantidad` | Just a text label |
| Text box for quantity | TextBox | `txtCantidad` | User types a number |
| Label "Distributor:" | Label | `lblDistribuidor` | Just a text label |
| Radio button "Cofarma" | RadioButton | `rbCofarma` | Select one distributor |
| Radio button "Empsephar" | RadioButton | `rbEmpsephar` | Select one distributor |
| Radio button "Cemefar" | RadioButton | `rbCemefar` | Select one distributor |
| Label "Branch:" | Label | `lblSucursal` | Just a text label |
| Checkbox "Principal" | CheckBox | `chkPrincipal` | Select pharmacy branch |
| Checkbox "Secundaria" | CheckBox | `chkSecundaria` | Select pharmacy branch |
| Button "Borrar" | Button | `btnBorrar` | Clear the form |
| Button "Confirmar" | Button | `btnConfirmar` | Submit the order |

For each control type, explain:
- **Label:** *"A Label just shows text. The user cannot edit it."*
- **TextBox:** *"A TextBox is an input field where the user can type."*
- **ComboBox:** *"A ComboBox (dropdown) shows a list of options. The user picks one."*
- **RadioButton:** *"RadioButtons work in groups — only one can be selected at a time. They are used when the user must choose exactly one option."*
- **CheckBox:** *"A CheckBox can be checked or unchecked independently. Use it when the user can select multiple options (or none)."*
- **Button:** *"A Button triggers an action when clicked. We attach an event handler to it."*

After adding controls, guide the user to:
- Set the `Text` property of labels and buttons.
- Add items to the ComboBox: Analgésico, Analéptico, Anestésico, Antiácido, Antidepresivo, Antibiótico.
- Group the RadioButtons inside a **GroupBox** control so WinForms knows they belong together (only one can be selected).
- Set the form `Text` property (title bar) to something like `"Sistema de Pedidos - Farmacia"`.

---

### STEP 3 — Write the Logic for Window 1

**Goal:** Write the C# code that handles button clicks and validates the form.

**Agent instructions:**

#### 3a. Explain Events in C#

*"In WinForms, when the user interacts with a control (clicks a button, types text, etc.), C# fires an **event**. We write **event handler** methods that run when those events happen. To attach a handler to a button click, double-click the button in the Designer — Visual Studio creates the method for you."*

#### 3b. The "Borrar" (Clear) Button

Write the `btnBorrar_Click` event handler. Guide the user to:
- Clear `txtMedicamento.Text`
- Reset `cmbTipo.SelectedIndex` to -1
- Clear `txtCantidad.Text`
- Uncheck all RadioButtons
- Uncheck both CheckBoxes

Explain: *"We are resetting every control to its default/empty state. `.Text = ""` clears a TextBox. `.SelectedIndex = -1` unselects a ComboBox. `.Checked = false` unchecks a RadioButton or CheckBox."*

#### 3c. The "Confirmar" (Confirm) Button — Validation

This is the most important method. Break it into clear sub-steps.

**Explain validation concept:** *"Before we process the order, we must check that all fields are filled in correctly. This is called input validation. If any field is wrong, we show an error message and stop. Only if everything is correct do we proceed."*

Write the `btnConfirmar_Click` handler with these validation checks, in order:

1. **Medication name:** Check that `txtMedicamento.Text.Trim()` is not empty and contains only alphanumeric characters.
   - Use `string.IsNullOrWhiteSpace()` for empty check.
   - Use a regular expression (`Regex.IsMatch`) or a loop for alphanumeric check.
   - Explain: *"`.Trim()` removes spaces at the start and end. `IsNullOrWhiteSpace` returns true if the string is empty or just spaces."*

2. **Medication type:** Check that `cmbTipo.SelectedIndex != -1`.
   - Explain: *"If `SelectedIndex` is -1, the user hasn't chosen anything."*

3. **Quantity:** Check that `txtCantidad.Text` can be parsed as a positive integer.
   - Use `int.TryParse()`.
   - Explain: *"`int.TryParse(text, out int result)` tries to convert a string to an integer. It returns `true` if it succeeds, `false` if it fails. This is safer than `int.Parse()` because it does not crash if the text is not a number."*
   - Also check that the parsed number is greater than 0.

4. **Distributor:** Check that at least one RadioButton is checked.
   - Use `rbCofarma.Checked || rbEmpsephar.Checked || rbCemefar.Checked`.

5. **Branch:** Check that at least one CheckBox is checked.
   - Use `chkPrincipal.Checked || chkSecundaria.Checked`.

For each failed validation, show a `MessageBox.Show("error message")` and `return` to stop execution.

Explain: *"`MessageBox.Show()` displays a pop-up dialog with a message. Calling `return` inside a method stops it immediately — the rest of the code below it won't run."*

**If all validations pass:**
- Collect the data into variables.
- Determine which distributor was selected (if/else on RadioButton.Checked).
- Build the address string based on which checkboxes are checked.
- Create and open **Window 2** (Form2), passing the collected data to it.

Explain how to open a new form: *"In WinForms, each window is a class that extends `Form`. To open a new window, we create an instance of it with `new Form2(...)` and call `.Show()` or `.ShowDialog()` on it. `.ShowDialog()` makes it modal — the user must interact with it before returning to Form1."*

---

### STEP 4 — Create Window 2 (Order Summary)

**Goal:** Create a second form that displays the order summary.

**Agent instructions:**

1. Add a new form to the project: Right-click the project → Add → New Item → Windows Form. Name it `Form2.cs`.

2. Explain: *"Form2 is just another class that inherits from `Form`. Just like Form1, it has a Designer where we can add controls, and a .cs file where we write its logic."*

3. **Design Form2** with these controls:

| Control | Type | Name | Purpose |
|---|---|---|---|
| Label for medication info | Label | `lblMedicamento` | Shows "X units of T M" |
| Label for address info | Label | `lblDireccion` | Shows the pharmacy address |
| Button "Cancelar" | Button | `btnCancelar` | Close this window |
| Button "Enviar Pedido" | Button | `btnEnviar` | Confirm and send the order |

4. Set the form's `Text` property dynamically (the title should say "Pedido al distribuidor D").

5. **Pass data from Form1 to Form2:**

   Explain: *"We need to send the order data from Form1 to Form2. We do this by creating a custom constructor in Form2 that accepts parameters."*

   Write a constructor in Form2 like:
   ```csharp
   public Form2(string distribuidor, string medicamento, string tipo, int cantidad, string direccion)
   {
       InitializeComponent();
       this.Text = "Pedido al distribuidor " + distribuidor;
       lblMedicamento.Text = cantidad + " unidades del " + tipo.ToLower() + " " + medicamento;
       lblDireccion.Text = "Para la farmacia situada en " + direccion;
   }
   ```

   Explain: *"A constructor is a special method that runs when an object is created. By adding parameters to the constructor, we force whoever creates a Form2 to provide the data it needs."*

6. **"Cancelar" button:** Call `this.Close()` to close Form2.

7. **"Enviar Pedido" button:** Show a `MessageBox.Show("Pedido enviado")`, then close Form2.

---

### STEP 5 — Build the Address String Logic

**Goal:** Build the address text based on which checkboxes are checked in Form1.

**Agent instructions:**

Explain the logic before writing code: *"There are three possible cases: only 'Principal' is checked, only 'Secundaria' is checked, or both are checked. We handle each case with if/else."*

```csharp
string direccion = "";
if (chkPrincipal.Checked && chkSecundaria.Checked)
    direccion = "Calle de la Rosa n. 28 y para la situada en Calle Alcazabilla n. 3";
else if (chkPrincipal.Checked)
    direccion = "Calle de la Rosa n. 28";
else if (chkSecundaria.Checked)
    direccion = "Calle Alcazabilla n. 3";
```

---

### STEP 6 — Test the Happy Path

**Goal:** Run the app and verify the full flow works when all data is correct.

**Agent instructions:**
1. Press **F5** or click the green Play button to build and run.
2. Fill in all fields correctly.
3. Click "Confirmar" — Form2 should open with the correct summary.
4. Click "Enviar Pedido" — the "Pedido enviado" message should appear.
5. Guide the user to take screenshots of this full flow (needed for the Word document).

---

### STEP 7 — Test Error Handling

**Goal:** Verify that every validation error shows correctly.

**Agent instructions:**

Guide the user to test each error case one by one:
1. Leave the medication name empty → should show error.
2. Enter non-alphanumeric characters (e.g., `@@@`) in medication name → should show error.
3. Leave the type unselected → should show error.
4. Enter `0`, a negative number, or text in the quantity field → should show error.
5. Don't select any distributor → should show error.
6. Don't check any branch → should show error.

Tell the user to take screenshots of each error message (needed for the Word document).

---

### STEP 8 — Add a Breakpoint for Debugging

**Goal:** Demonstrate the Visual Studio debugger with a breakpoint inside `btnConfirmar_Click`.

**Agent instructions:**

Explain what a breakpoint is: *"A breakpoint is a marker you place in your code that tells the debugger to pause execution at that exact line. When the program pauses, you can inspect the current values of all variables, step through code line by line, and understand exactly what your program is doing. This is extremely useful for finding bugs."*

Step-by-step:
1. Open `Form1.cs`.
2. Click in the grey margin to the left of the first line inside `btnConfirmar_Click`. A red dot appears — that's the breakpoint.
3. Press **F5** to run in Debug mode.
4. Fill in the form and click "Confirmar".
5. The program will pause at the breakpoint. The current line is highlighted in yellow.
6. Show the user the **Locals** window (Debug → Windows → Locals) to inspect variable values.
7. Use **F10** (Step Over) to execute one line at a time.
8. Tell the user to take a screenshot of this paused state (needed for the Word document).

---

### STEP 9 — Code Cleanup and Comments

**Goal:** Make the code readable and well-commented.

**Agent instructions:**

Explain: *"Good code is not just code that works — it is code that is easy to read and understand. Adding comments (lines that start with `//`) helps you and others understand what each part does."*

Guide the user to add comments above each major block:
- Above the validation section: `// Validate form inputs before processing the order`
- Above each individual check: `// Check that medication name is not empty`
- Above the Form2 creation: `// All validations passed — open the order summary window`

---

### STEP 10 — Word Document

**Goal:** Help the user write the required Word document.

**Agent instructions:**

The document must include:
1. **Screenshots of the two windows** during a correct order flow (Form1 filled → Form2 summary).
2. **Explanation of error handling:** How validation works, what errors are caught, and how the user is notified. Include screenshots of each error message.
3. **Debugging screenshot:** A screenshot of the breakpoint paused inside `btnConfirmar_Click`, showing the Locals window with variable values.

Suggested structure for the document:
- Section 1: Introduction (brief description of the app)
- Section 2: Order flow screenshots (the happy path)
- Section 3: Error handling explanation + screenshots
- Section 4: Debugging — breakpoint screenshot + explanation

Remind the user: font Georgia 11, line spacing 1.5, max 10 pages.

---

## Key C# Concepts the Agent Should Explain Along the Way

| Concept | When to explain |
|---|---|
| Classes and objects | When creating Form2 |
| Constructors | When passing data to Form2 |
| Event handlers | When writing button click logic |
| `string` methods (Trim, IsNullOrWhiteSpace) | During validation |
| `int.TryParse` | During quantity validation |
| `MessageBox.Show` | When showing error messages |
| `this.Close()` | When closing Form2 |
| `new Form2(...).ShowDialog()` | When opening Form2 |
| Breakpoints and the debugger | Step 8 |
| Comments | Step 9 |

---

## Deliverables Checklist

- [ ] Visual Studio project compiles without errors
- [ ] Form1 has all required controls (TextBox, ComboBox, RadioButtons, CheckBoxes, 2 Buttons)
- [ ] "Borrar" clears all fields
- [ ] "Confirmar" validates all 5 fields and shows appropriate error messages
- [ ] Form2 opens with correct title, medication text, and address text
- [ ] "Cancelar" closes Form2
- [ ] "Enviar Pedido" shows "Pedido enviado" message
- [ ] Breakpoint screenshot taken
- [ ] Word document complete with screenshots and explanations
- [ ] Everything zipped into a single compressed file for submission

---

## Notes for the Agent

- **The user types the code. Always.** Show it, explain it, then let them write it.
- Present code in **small, digestible pieces** — never dump an entire file at once.
- After explaining a piece of code, let the user work. Do not prompt them to move on.
- If the user gets a compiler error, **explain what the error message means** in plain language before guiding them to fix it. Do not just paste the fix.
- Encourage the user when they get something working — but keep it natural, not performative.
- If the user asks "why does this work?" or "what does this line do?", answer fully before continuing. Never say "we'll get to that later" unless it is genuinely a topic for a future step.
- Keep Spanish terminology where it appears in the UI (labels, button text, error messages), but use English conventions for code (variable names, method names in camelCase).
- **Never ask "ready for the next step?", "shall we continue?", or any variation of this.** The user leads the pace.