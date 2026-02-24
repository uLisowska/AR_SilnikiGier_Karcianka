using UnityEngine;
using UnityEngine.UI;

public class SwitchAnimationsK : MonoBehaviour
{
    [SerializeField] Animator rumba;
    [SerializeField] Animator silly;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SwitchAnimationsForth);
    }

    private void SwitchAnimationsForth()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();

        rumba.Play("Silly");
        silly.Play("Rumba");

        GetComponent<Button>().onClick.AddListener(SwitchAnimationsBack);
    }

    private void SwitchAnimationsBack()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();

        silly.Play("Silly");
        rumba.Play("Rumba");

        GetComponent<Button>().onClick.AddListener(SwitchAnimationsForth);
    }
}