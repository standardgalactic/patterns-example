### List
#### Behavioral
1. **Strategy**  - just implementing the meaning of an abstract class or interface and nothing more.
1. **Template**. Often used, natural as a strategy pattern. One of the implemented methods calls several abstract methods.Similar to Factory.
1. **Visitor** Nice pattern, I would call Combinator or Heir, something like that.
1. **ChainofResponsibility** +
In general, the pattern, judging by the name, is obvious and in demand: each actor has, or at least needs, one to whom a task can be delegated.
Class "A" has a "next" property of type "B". "A" and "B" implement the same interface, so you can chain A.next=>B.next=>C.next
Thus, the process of coordinating documents always goes on. First, the document gets on the table to the secretary or the first person, which structures are determined, the chiefs of lower rank must agree on it and in what sequence.
If "next" is not set, the case when the task is outside the competence of the current actor, and it is not possible to delegate it to someone, then an error is thrown.
But still, the pattern is a little far-fetched. Programming usually consists of chains of calls like A.method1 => B.method2=>C.method3. If the names of the methods are the same, nothing changes dramatically.

1. **Command**  + The pattern is useful when you want to leave the ability to undo/rollback (Undo) or redo (Redo) an operation. Information about the performed operations is stored in an array.The calculator is a very good example.. +
1. **Interpreter**  Похоже на фабрику.Продукт проходит последовательную обработку. Похож на chainofResponsibility паттерн.Взаимозаменяемы.
1. **Iterator** -  Enumeration, не значим. 
1. **Mediator** + Участник чата вызывает команду Chat.Send. Сhat сохраняет информацию в классе участника. 
1.  **Memento** state saving Cохранение состояние класса.  Фишка в том  класс, который служит для сохранения состояния Memento инкапсулирован, private. 
1. **State** +  pattern that allows an object to alter its behavior when its internal state changes. 
The state pattern can be interpreted as a strategy pattern, which is able to switch a strategy.The state pattern is used in computer programming to encapsulate varying behavior for the same object, based on its internal state. This can be a cleaner way for an object to change its behavior at runtime without resorting to conditional statements and thus improve maintainability
1. **Observer** + Хороший патерн
 
#### Structural
1. **Adapter** Можно ли конвертировать один тип в другой, не используя adapter?
1. **Bridge**  огород.Предположим список использует массив. Оба класса наследуют от одного интерфейса.
1. **Composite**
1. **Decorator**
1. **Facade** Так выглядит сервис. В контексте  проверки контрагента, обработки запросов парсинг, логирование запись в DBase
2.  **FlyWeight**
3. **Proxy**  + Наверняка используется. В принципе логичен. 
 
#### Creational
1.**Abstract** + Используется
1. **Builder** + Действия определены интерфейсом. 
1. **Factory** Similar template -
1. **LazyInitialization** Lazy class
1. **ObjectPool**
1. **Prototype** - Clone pnecозданиe класса через клонирование.  
2. **Singleton** + complicate testing   
3. **MultiTon** +  several singleton, it complicates testing
1. **ResourceAcquisition**


> Any programmer who uses  interfaces and abstract classes is programming with patterns in any way. There is no another choice.
 
##### The Twelve Chairs
"On the third move it turned out that the grandmaster was playing eighteen Spanish games. In the remaining twelve, Black used the outdated, but quite correct Philidor Defense. If Ostap had learned that he was playing such tricky games and facing such a proven defense, he would have been extremely surprised. The fact is that the great schemer played chess for the second time in his life."

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





