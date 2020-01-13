
using UnityEngine;
// using UnityEngine.UI;

public class MoveBallScript : MonoBehaviour
{
[SerializeField]  private GameObject[] ballPositions;
public GameObject ball;
int RandomPos;
int PosBefore;

void SetBallRandom() {
    RandomPos = 0;

    PosBefore =4;
}
void SetPosition() {
ball.transform.position = ballPositions[RandomPos].transform.position;
}

public void getPosBefore(){
RandomPos = Random.Range(0,4);
    if (RandomPos != PosBefore)
{
PosBefore = RandomPos;
SetPosition();
}
else {
    getPosBefore();
}

}

}




    

