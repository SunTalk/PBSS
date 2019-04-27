using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Istate 
{
    void Enter(BaseControll baseControll);
    void UPDATE();
    void Exit();
}
