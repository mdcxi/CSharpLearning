using System;

class Indexer <I>
{
    //declare an array to store elements
    private I[] array = new I[16];
    
    //define indexer
    public I this[int i]
    {
        get { return array[i]; }
        set { array[i] = value;  }
    }
}