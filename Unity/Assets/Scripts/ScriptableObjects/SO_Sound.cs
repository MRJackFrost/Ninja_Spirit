using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundData_New", menuName = "SoundData")]
public class SO_Sound : ScriptableObject, ISerializationCallbackReceiver
{
    public float backgroundvolume = 0;

    void ISerializationCallbackReceiver.OnAfterDeserialize()
    {
        
    }


    void ISerializationCallbackReceiver.OnBeforeSerialize()
    { }
}
