# Parity Solution

## Intro
The most straight-forward way to solve this is by dividing the initial number by 2 (as an integer)
If the number is odd - There should be a 1 in binary in that index.
If the number is even - There should be a 0 in binary in that index.
Considering that, we keep dividing by 2 until we reach 1.

In this specific solution, we are counting the amount of 1-s.

The complexity of this solution is *O(log(n))*

## Simple Solution
The simple solution is one method, an implementation of IParitySolution in tge BasicParitySolution class.
It does what the intro describes in the same method.


## Generic Solution
The idea here was to over-engineer things for the sake of abstraction and testability.
Of course, for this specific case, this is an overkill.
But what I want to show here, is the abstract understanding of the solution, and how I would generalise it and test it's components.

```
We have 4 parts to the solution:

1. Iteration until a stop condition is reached
2. Check if the current entity responds to a certain condition
3. If so, perform a certain action on that entity
4. Mutate the entity in order to continue the iteration.

```

And start again from point 1.

So, let's decouple those 4 actions, and test each one of them.

1. Stop condition - is a condition, so it implements the ICondition interface.
It is located in  in Parity/Services/Conditions/GreaterThanCondition.cs

2. Certain condition that is applied to an entity - that is the OddNumberCondition. If a number is odd - we want to do something.
Locaed in Parity/Services/Conditions/OddNumberCondition.cs

3. Perform a certain action - in this case, we simply want to count.
So for that, let's use an instance of SimpleCounter. 
Currently, the interface requires us to pass something into that Action. That is for the future, should we want to perform an action based on the current state of the entity.
In our current example, we simply ignore this input and just add +1 to the counter.

4. Mutate the entity - we want to mutate the current number so that the iteration won't be infinite.
The mutator can be found in IteratorMutators/NumericMutator.
In our case, the mutator divides the current number by 2.


Finally, we need a flow.
Our flow, as generic as it can be, is *performing an action* based on *a condition* until an *end condition* is met. Each iteration will *mutate the entity*.
This flow is just one way to iterate over an entity, and perform an action.
So for that, we have the **IActionableEntityRunner** interface, and it's straightforward implementation - **BasicActionableEntityRunner**.

Finally, in Program.cs - you can see the simple solution being run, and then the complex - generic one.

## Running instructions

This solution is built on dotnetcore 2
To run it, you would need to have dotnetcore installed.
For the tests, it requires NUnit and Microsoft Test SDK.

## Running instructions

Last number is the argument for the program:

```
dotnet run -p ./Parity -- 8
```

## Test instructions

```
dotnet test
```