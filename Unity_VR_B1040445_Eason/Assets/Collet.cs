using UnityEngine;
using UnityEngine.UI;

public class Collet : MonoBehaviour
{
    public int playerScore;
    public Text textsay;

   public void ThrowDetach(GameObject obj)
    {
        Destroy(obj);
        if(obj.gameObject.tag=="Gold")
        {
            playerScore += 100;
            textsay.text = "分數:"+playerScore.ToString();
        }
        else if(obj.gameObject.tag=="Sliver")
        {
            playerScore += 60;
            textsay.text = "分數:"+playerScore.ToString();
        }
        
       // if(obj.gameObject.tag=="Sliver")
        //{
          //  playerScore += 60;
        //}
    }
}
