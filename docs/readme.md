
#### Behavioral
1. **Strategy**  - just implementing the meaning of an abstract class or interface and nothing more.
1. **Template**. Often used, natural as a strategy pattern. One of the implemented methods calls several abstract methods. Similar to Factory.
1. **Visitor** The nice pattern, I would call it  as a combinator or a Heir, something like that.
1. **ChainofResponsibility** +
In general, the pattern, judging by the name, is obvious and in demand: each actor has, or at least needs, one to whom a task can be delegated.
Class "A" has a "next" property of type "B". "A" and "B" implements the same interface, so you can chain A.next=>B.next=>C.next
Thus, the process of coordinating documents always goes on. First, the document gets on the table to the secretary or the first person, which structures are determined, the chiefs of lower rank must agree on it and in what sequence.
If "next" is not set, the case when the task is outside the competence of the current actor, and it is not possible to delegate it to someone yet, then an error is thrown.
But still, the pattern is a little far-fetched. Any programming usually consists of chains of calls like A.method1 => B.method2=>C.method3. If the names of the methods are the same, nothing changes dramatically.

1. **Command**  + The pattern is useful when you want to leave the ability to undo/rollback (Undo) or redo (Redo) an operation. Information about the performed operations is stored in an array.The calculator is a very good example. +
1. **Interpreter**  It looks like a factory. The product goes through sequential processing. Similar to the chainofResponsibility pattern.  they are interchangeable.
1. **Iterator** -  Enumeration, not significant. 
1. **Mediator** + The chat participant calls the Chat.Send command. The chat stores information in the participant class.
1.  **Memento** state saving Saving the state of the class. The trick is that the class that serves to save the Memento state is encapsulated, private. 
1. **State** +  pattern that allows an object to alter its behavior when its internal state changes. 
The state pattern can be interpreted as a strategy pattern, which is able to switch a strategy.The state pattern is used in computer programming to encapsulate varying behavior for the same object, based on its internal state. This can be a cleaner way for an object to change its behavior at runtime without resorting to conditional statements and thus improve maintainability.
1. **Observer** + Good  patterп.
 
#### Structural
1. **Adapter** Is it possible to convert one type to another without using adapter?
1. **Bridge**  Fine pattern. People have similar roles, but depending on their nature, everyone performs them differently.
1. **Composite**
1. **Decorator**
1. **Facade** This is what the service probably looks like. Checking counterparties, processing requests, parsing, logging, recording in database.
1.  **FlyWeight**
1. **Proxy**  + It's probably used. In principle it is logical.
 
#### Creational
1. **Abstract** + often used
1. **Builder** + actions are defined by the interface. 
1. **Factory** Similar template -
1. **LazyInitialization**  -lazy class
1. **ObjectPool**
1. **Prototype** - class creation through cloning.
1. **Singleton**  complicate testing   
1. **MultiTon**   several singleton, it complicates testing.
1. **ResourceAcquisition**

> By and large any programmer who uses  interfaces and abstract classes is programming with patterns in any way. There is no another choice.
 
### As a joke, I present excerpts from 2 books.

##### The Twelve Chairs by Ilf and Petrov
On the third move it turned out that the grandmaster was playing eighteen Spanish games. In the remaining twelve, Black used the outdated, but quite correct Philidor Defense. If Ostap had learned that he was playing such tricky games and facing such a proven defense, he would have been extremely surprised. The fact is that the great schemer played chess for the second time in his life.

##### THE MIDDLE CLASS GENTLEMAN(Le Bourgeois Gentilhomme) By MOLIÈRE
MONSIEUR JOURDAIN: Please do. But now, I must confide in you.  
I'm in love with a lady of great quality, and I wish that you would help me write something to her in a little note that I will let fall at her feet.   
PHILOSOPHY MASTER: Very well.   
MONSIEUR JOURDAIN: That will be gallant, yes?   
PHILOSOPHY MASTER: Without doubt. Is it verse that you wish to write her?   
MONSIEUR JOURDAIN: No, no. No verse.   
PHILOSOPHY MASTER: Do you want only prose?   
MONSIEUR JOURDAIN: No, I don't want either prose or verse.   
PHILOSOPHY MASTER: It must be one or the other.   
MONSIEUR JOURDAIN: Why?   
PHILOSOPHY MASTER: Because, sir, there is no other way to express oneself than with prose or verse.   
MONSIEUR JOURDAIN: There is nothing but prose or verse?   
PHILOSOPHY MASTER: No, sir, everything that is not prose is verse, and everything that is not verse is prose.   
MONSIEUR JOURDAIN: And when one speaks, what is that then?   
PHILOSOPHY MASTER: Prose.   
MONSIEUR JOURDAIN: What! When I say, "Nicole, bring me my slippers, and give me my nightcap," that's prose?   
PHILOSOPHY MASTER: Yes, Sir.   
MONSIEUR JOURDAIN: By my faith! For more than forty years I have been speaking prose without knowing anything about it, and I am much obliged to you for having taught me that.  





