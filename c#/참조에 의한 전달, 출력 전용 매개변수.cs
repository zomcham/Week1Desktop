using UnityEngine;

 privat void Awake()
 {
    int a=5, b=4, result=0, result2=0
    Divide(a,b,ref result1, ref result2);
    Debug.Log($"몫={result1}, 나머지={result2});
 }

 public void Divide(int num1, ref num2, ref int result1, ref int result2)
 {
    result1=num1/num2;
    result2=num1%num2;
 }