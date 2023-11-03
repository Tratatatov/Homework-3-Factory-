using UnityEngine;
using UnityEngine.UI;


public class IconSwitcher : MonoBehaviour
{
    [SerializeField] private Image _energyIcon;
    [SerializeField] private Image _coinIcon;
    private IconFactory _currentFactory;
    private PixelFactory _pixelFactory;
    private HDFactory _hdFactory;
    private void Awake()
    {
        _pixelFactory = new PixelFactory();
        _hdFactory = new HDFactory();
        _currentFactory = _pixelFactory;
        SetIcons();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            _currentFactory = _hdFactory;
            SetIcons();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            _currentFactory = _pixelFactory;
            SetIcons();
        }
    }
    private void SetIcons()
    {
        _energyIcon.sprite = _currentFactory.GetEnergySprite();
        _coinIcon.sprite = _currentFactory.GetCoinSprite();
    }
}
