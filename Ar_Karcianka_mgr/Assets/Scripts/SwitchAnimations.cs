using UnityEngine;
using UnityEngine.UI;

public class SwitchAnimations : MonoBehaviour
{
    [SerializeField] Animator taunt;
    [SerializeField] Animator stretch;
    void Start()
    {
        GetComponent<Button>().onClick.AddListener(SwitchAnimationsForth);
    }

    private void SwitchAnimationsForth()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();

        taunt.Play("Stretch");
        stretch.Play("Taunt");

        GetComponent<Button>().onClick.AddListener(SwitchAnimationsBack);
    }

    private void SwitchAnimationsBack()
    {
        GetComponent<Button>().onClick.RemoveAllListeners();

        stretch.Play("Stretch");
        taunt.Play("Taunt");

        GetComponent<Button>().onClick.AddListener(SwitchAnimationsForth);
    }
}
