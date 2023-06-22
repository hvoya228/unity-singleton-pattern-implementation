# Explaining    

### What is Singleton in Unity?  
Singleton in Unity means that you have a global access class,  
which have only one instance on the scene.  

--- 

### Why do you need this?  
Imagine that you have a game with score system.  
And you need to give only one score implementation to some UI implementations.  
Singleton pattern gives you confidence that only one object of singleton class will be implemented.  

---  

### How to make it?  
All you need to implement this pattern is make the Instance property,  
for the class, which will be used to access the object.  
Also you have to write some logic for the existence of only one object.  

```c#
public class ScoreController : MonoBehaviour
{
    [SerializeField] private int scoreCount;

    public int ScoreCount { get { return scoreCount; } }
    public static ScoreController Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Debug.Log(gameObject.name + " deleted");
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }
}
```  

In the code block you can see the Instance property and only one existence object logic wrote in the Awake.  
Because of the static property Instance will be asigned only once in the Awake, other asigned components will be destroyed.  

--- 

### How to use the Singleton class in other classes?  
To use Singleton in other classes you have to make an object of this class and asign the Instance of Singletone class.  

```c#
[RequireComponent(typeof(Text))]
public class ScoreText : MonoBehaviour
{
    private Text scoreText;
    private ScoreController scoreController;

    private void Start()
    {
        scoreText = GetComponent<Text>();
        scoreController = ScoreController.Instance;
        ScoreToText();
    }

    private void ScoreToText()
    {
        scoreText.text = "score: " + scoreController.ScoreCount.ToString();
    }
}
```  

In the code block you can see the ScoreController object,  
inside of which is asigned the instance of ScoreController class.  

--- 

### How it works?  

Let`s create two text objects to see score on the screem and  
two objects with score controller component with different score given to see how it work.    

Let`s run the game and see what happens.  

You can see that text objects are:  
```c#
score: 20
score: 20
```

We can understand that UI shows score only of one score controller.  
Also you can see that score controller`s component was deleted from the first object by Debug.Log.  
We can conclude that our Singleton implementation do not delete component only from newest created object.  

---  

git pull the project to see how it works

