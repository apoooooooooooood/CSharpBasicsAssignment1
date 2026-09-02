# C# Basics Assignment

A course assignment covering C# fundamentals: project structure, variable types and casting, value vs. reference types, scope and operators, memory diagrams, and a LeetCode problem.

## Project Structure

```
CSharpBasicsAssignment/
├── CSharpBasicsAssignment.csproj
├── Program.cs
├── Order.cs
├── STACK_HEAP.md
├── README.md
└── ANSWERS.md
```

## Grading Breakdown (115 points total)

| Part | Topic | Points |
|------|-------|--------|
| A | Project & Structure | 10 |
| B | Variables, Types & Casting | 25 |
| C | Value vs. Reference Types | 30 |
| D | Scope & Operators | 20 |
| E | Draw the Stack & Heap (Markdown) | 15 |
| F | LeetCode Problem | 10 |
| G | Short Answer | 5 |

---

## Part A — Project & Structure (10 pts)

Demonstrate understanding of a project's building blocks, not just how to run it.

- Explain in code comments at the top of `Program.cs` the role of: `.csproj`, `Program.cs`, `obj/`, and `bin/`.
- Confirm `OutputType`, `TargetFramework`, `ImplicitUsings`, and `Nullable` are set in the `.csproj` (paste contents in Part G, Q1).
- Add a file-scoped namespace to `Program.cs` and explain in a comment why it removes a level of indentation.
- State (in a comment) whether the project uses `.sln` or `.slnx`, and one advantage of the format not chosen.

## Part B — Variables, Types & Casting (25 pts)

Implement `RunTypesDemo()` covering:

- Every type: `int`, `long`, `double`, `decimal`, `bool`, `char`, `string`, and one `var`-inferred value — print each value and its runtime type via `.GetType()`.
- Implicit conversions: `int` → `long`, `char` → `int` — explain why no cast is required.
- Explicit conversions: `(int)` cast on a `double` vs. `Convert.ToInt32` — explain truncation vs. rounding.
- Integer division trap: `5 / 2` (int) vs. `5.0 / 2` (double).
- Boxing/unboxing: box an `int` into `object`, then unbox it back.
- Parsing: `int.Parse("42")` and `int.TryParse("abc", ...)` — handle failure without throwing.
- `float` → `decimal`: show the implicit assignment fails (commented out), then do it correctly with an explicit `(decimal)` cast.

## Part C — Value vs. Reference Types (30 pts)

Implement `RunValueVsReferenceDemo()` with two experiments.

**Experiment 1 — struct copy semantics**
- `struct Point { public int X; public int Y; }`
- Copy `p1` into `p2`, mutate `p2.X`, and show `p1.X` and `p2.X` differ.

**Experiment 2 — class reference semantics (`Order`)**
- `Order` class with exactly 10 concrete-typed fields (no `object` fields) and 2 methods:
  - `CalculateTotal()` — computes `TotalPrice` from `Quantity`, `UnitPrice`, `DiscountPercent`.
  - `PrintSummary()` — prints `OrderId`, `CustomerName`, `TotalPrice`, `IsPaid`.
- Assign `o2 = o1`, mutate `o2.IsPaid`, and show `o1.IsPaid` and `o2.IsPaid` are identical (shared heap identity).
- Assign `o1` to an `object` variable and cast back, confirming `object.ReferenceEquals` returns true.
- Call `o2.PrintSummary()` to confirm it reflects the change made through `o2`.
- Close with a 3–5 sentence explanation of stack vs. heap, what assignment copies for each type, and why storing a reference type in an `object` variable doesn't create a new object.

## Part D — Scope & Operators (20 pts)

**D1 — Scope**
- A private field read from two different methods (field scope).
- A local variable not visible outside its method (method scope).
- A for-loop variable that dies after the loop, with a comment explaining the resulting compile error (block scope).

**D2 — Compound assignment operators**
- Apply `+=`, `-=`, `*=`, `/=`, `%=` to `total = 100`, printing after each step.
- Rewrite one line in long form to show equivalence.

**D3 — Bitwise operators**
- `int a = 12`, `int b = 10` (binary `1100` and `1010`).
- Print and explain `a & b`, `a | b`, `a ^ b` bit-by-bit.
- One sentence contrasting `&` (bitwise) vs. `&&` (logical) short-circuit behavior.

## Part E — Draw the Stack & Heap (15 pts)

In `STACK_HEAP.md`, using the `Order` class, draw 3 diagrams (ASCII/Markdown boxes or fenced code blocks) for:

```csharp
Order o1 = new Order { OrderId = 1, CustomerName = "Ali" };
Order o2 = o1;
o2.IsPaid = true;
```

- Diagram 1: `o1` on the stack pointing to a heap object.
- Diagram 2: `o2` added to the stack, pointing at the same heap address.
- Diagram 3: heap object's `IsPaid` updated; both variables still point at it.
- One sentence per diagram explaining what changed.
- A closing section: **"What would be different with structs?"** using `Point` as the comparison.

## Part F — LeetCode Problem (10 pts)

**[LeetCode 136 — Single Number](https://leetcode.com/problems/single-number/)**

> Given a non-empty array of integers where every element appears twice except one, find that single element in linear time and constant space.

```
Input:  nums = [4, 1, 2, 1, 2]
Output: 4
```

- Implement `int FindSingleNumber(int[] nums)` using XOR (`^`) only — no dictionaries, sorting, or extra arrays.
- Comment explaining why XOR-ing all numbers isolates the element with an odd count.
- Test with at least two different arrays.

## Part G — Short Answer (5 pts)

Submit as comments or a separate `ANSWERS.md`:

1. Paste `.csproj` contents and confirm the four Part A properties are present.
2. Do `#region` / `#endregion` change compiled output? Why use them anyway?
3. When to use `///` XML doc comments instead of `//`?
4. Why does C# have no true global variables, and what's the closest equivalent?

## Submission

Submitted through the course repository with the structure shown above.