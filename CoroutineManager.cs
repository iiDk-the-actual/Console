﻿using System.Collections;
using UnityEngine;

namespace Console
{
    public class CoroutineManager : MonoBehaviour // Thanks to ShibaGT for helping with the coroutines
    {
        public static CoroutineManager instance = null;

        private void Awake() =>
            instance = this;

        public static Coroutine RunCoroutine(IEnumerator enumerator) =>
            instance.StartCoroutine(enumerator);
        
        public static void EndCoroutine(Coroutine enumerator) =>
            instance.StopCoroutine(enumerator);
    }
}
