# LotteryRandom
## Description
LotteryRandom is a generic management system for picking random list entries in Unity 3D. It enables you to get random list entries based on a lottery functionality, so that in one go the same entry is not returned twice in a row. Its functionallity is meant to be used for instance on Footsteps, Sprites or SpawnPoints as well as value data types and many more. It ensures that the same AudioClip is not played repeatedly, which could happen by generating a simple random ID.
## Features
* Internal List Management (simply call a LotteryRandom function on a List and it enters a dictionary)
* Extension Method Wrapper
* Generic List Entries
* LotteryMode (controle what happens, when all list entries have been returned)

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

