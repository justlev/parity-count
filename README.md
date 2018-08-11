# Parity Solution

## Intro
The most straightforward way to solve this is by dividing the initial number by 2 (as an integer). <br />
If the number is odd - There should be a 1 in binary in that index. <br />
If the number is even - There should be a 0 in binary in that index. <br />
Considering that, we keep dividing by 2 until we reach 1. <br />

In this specific solution, we are counting the amount of 1-s.

The complexity of this solution is **O(log(n))**

## Simple Solution
The solution is implemented in one method that contains all the logic, in the BasicParitySolution class (implementation of IParitySolution).

## Generic Solution
The idea here was to over-engineer things for the sake of abstraction and testability.
Of course, for this specific case, this is an overkill.
But what I want to show here, is the abstract understanding of the solution, and how I would generalise it and test the components.

```
We have 4 parts to the solution:

1. Iterating until a stop condition is met.
2. Check if the current entity responds to a certain condition.
3. If so, perform a certain action on that entity.
4. Mutate the entity in order to continue the iteration.

And start again from point 1.
```


So, let's decouple those 4 actions, and test each one of them.

1. Stop condition - is a condition, so it implements the ICondition interface.
We want to run while the number is more than 0.
It is located in Parity/Services/Conditions/GreaterThanCondition

2. Certain condition that is applied to an entity - that is the OddNumberCondition. If a number is odd - we want to do something.
Located in Parity/Services/Conditions/OddNumberCondition

3. Perform a certain action - in this case, we simply want to count.
So for that, let's use an instance of the SimpleCounter. 
Currently, the flow interface requires us to pass the current entity into that Action. That is for the future, should we want to perform an action based on the current state of the entity.
In our current example, we simply ignore this input and just add +1 to the counter.

4. Mutate the entity - we want to mutate the current number so that the iteration won't be infinite.
The mutator can be found in IteratorMutators/NumericMutator.
In our case, the mutator divides the current number by 2.


Finally, we need a flow that glues all of that together.
Our flow, as generic as it can be, is *performing an action* based on *a condition* until an *end condition* is met. Each iteration will *mutate the entity*.
This flow is just one way to iterate over an entity, and perform an action.
So for that, we have the **IActionableEntityRunner** interface, and it's straightforward implementation - **BasicActionableEntityRunner**.

Finally, in Program.cs - you can first see the simple solution being run, and then the complex - generic one.

## Running instructions

This solution is based on dotnetcore 2. <br />
To run it, you need to have dotnetcore installed. <br />
Tests require NUnit and Microsoft Test SDK.

## Running instructions

Last number is the argument for the program.
Run this in the CLI, to count the 1-s in the decimal number 1000000:

```
dotnet run -p ./Parity -- 1000000
```

## Test instructions

Run this in the CLI:

```
dotnet test
```