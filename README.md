# LotteryRandom
## Description
LotteryRandom is a generic management system for picking random list entries in Unity 3D. It enables you to get random list entries based on lottery functionality, so that in one go the same entry is not returned twice in a row. Its functionality is meant to be used for instance on Footsteps, Sprites or SpawnPoints as well as value data types and many more. It ensures that the same AudioClip is not played repeatedly, which could happen by generating a simple random ID.
## Features
* Internal List Management (simply call a LotteryRandom function on a List and it enters a dictionary)
* Extension Method Wrapper
* Generic List Entries
* LotteryMode (control what happens, when the passed list is empty)
* Example Scene with a customized Editor
* Fully commented source code

## How to Use
Use the PolyPaw and LotteryRandom namespace and call its methods on the list itself as an ExtensionMethod.
```C#
use PolyPaw.LotteryRandom

class SomeClass
{
	public int[] ints = { 0, 1, 2, 3 };
    
    public int DrawNextNumber()
	{
		return ints.DrawNext ();
	}
}
```

## Performance Optimization
For future work I intent to make some changes in order to gain some performance. So far the system is based on iLists where entries are removed after return. This is an expensive operation, which can be improved by pre-shuffling the list and then return the list entries in a linear manner.
