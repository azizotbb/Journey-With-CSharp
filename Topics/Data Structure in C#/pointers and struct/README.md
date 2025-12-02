# Pointers in C#

## 🔹 What Is a Pointer?

A **pointer** is a variable that stores the **memory address** of another variable.

- A normal variable → stores a value
- A pointer → stores the _location where the value is stored_

---

## 🔹 Why Do We Use Pointers?

Pointers are used for:

- Direct memory access
- Passing variables to functions by reference
- Working with arrays
- Dynamic memory allocation (`new` / `delete`)
- Building data structures (linked lists, trees, etc.)

---

## 🔹 How to Declare a Pointer

```cpp
type* pointerName;

```

## 🔹 Assigning a Pointer to a Variable

```cpp
int x = 10;
int* p = &x;


```

# Struct in C#

## 🔹 What Is a `struct`?

A **struct** (short for _structure_) is a user-defined data type that lets you group multiple variables under one name.  
It’s useful when you want to store related data together.

Example: A student has a **name**, **age**, and **grade** → instead of using 3 separate variables, you create one `struct`.

---

## 🔹 Basic Example

```cpp
struct Student {
    string name;
    int age;
    float grade;
};
```

## 🔹 Creating and Using a Struct

```cpp
Student s1;
s1.name = "Ali";
s1.age = 20;
s1.grade = 88.5;
```

## 🔹 Initializing a Struct Directly

```cpp
Student s2 = {"Sara", 19, 92.3};
```

## 🔹 Array of Structs

```cpp
Student students[3] = {
    {"Ali", 20, 90},
    {"Sara", 19, 85},
    {"Omar", 21, 70}
};
```
