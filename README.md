# Explaining    

### What is Singleton in Unity?  
Singleton in Unity means that you have a global access class,  
which have only one instance on the scene.  

--- 

### Why do you need this?  
Imagine that you have a game with score system.  
And you need to give only one score implementation to some UI implementations.  
Singleton pattern gives you confidence that only one object  
of singleton class will be implemented.  

---  

### How to make it?  
All you need to implement this pattern is make the Instance property,  
for the class, which will be used to access the object.  
Also you have to write some logic for the existence of only one object.  

![Code Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/ScoreControllerScript.png)  

On the image you can see the Instance property and  
only one existence object logic wrote in the Awake.  
Because of the static property Instance will be  
asigned only once in the Awake, other asigned components will be destroyed.  

--- 

### How to use the Singleton class in other classes?  
To use Singleton in other classes you have to  
make an object of this class and asign the Instance of Singletone class.  

![Code Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/ScoreTextScript.png)  

On the image you can see the ScoreController object,  
inside of which is asigned the instance of ScoreController class.  

--- 

### How it works?  

Let`s create two score texts and two score controllers to check how it work.  

![Hierarchy Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/Hierarchy.png)  

![Inspector Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/ScoreControllerInspector.png)  

![Inspector Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/ScoreController1Inspector.png)  

Now we have two score controllers with diferent score given in the Inspector.  
And two score texts, which have to show only one score controller`s score.  

Let`s run the game and see what happens.  

![Game window Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/GameScreen.png)  

![Console Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/DebugLog.png)  

![Score controller inspector Example Image](https://github.com/chugaister228/unity-singleton-pattern-implementation/blob/main/Prewievs/ScoreControllerGameModeInspector.png)  

On the images we can that UI shows score only of one score controller.  
Also you can see that score controller`s component was deleted from  
the first object.  
We can conclude that our Singleton implementation do not delete component only  
from newest created object.  

---  

git pull the project to see how it works

