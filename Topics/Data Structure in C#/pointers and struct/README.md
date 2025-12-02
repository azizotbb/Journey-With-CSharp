# Pointers in C++

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
