using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHitable
{
    bool Hit(int amt);
}
public interface IInteractable
{
    bool Interact(GameObject g);
}

