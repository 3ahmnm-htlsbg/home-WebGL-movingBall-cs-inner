
using UnityEngine;
// using UnityEngine.UI;

public class MoveBallScript : MonoBehaviour
{
[SerializeField]  private GameObject[] ballPositions;
public GameObject ball;
int RandomPos;
int PosBefore;

public void SetBallRandom() {

ball.transform.position = ballPositions[RandomNumber()].transform.position;
}
int RandomNumber() {
RandomPos = Random.Range(0,4);
while(RandomPos == PosBefore) {
RandomPos = Random.Range(0,4);
}
PosBefore = RandomPos;
return RandomPos;
}


}

    

