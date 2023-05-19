using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubclassAttribute : PropertyAttribute
{
    public bool IncludeSelf = false;
    public bool IsList = false;

    public SubclassAttribute(bool InIncludeSelf = false, bool InIsList = false)
    {
        IncludeSelf = InIncludeSelf;
        IsList = InIsList;
    }
}
