using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankTypes tankTypes;
    public Material color;

    public TankModel(float _movementspeed, float _rotationspeed, TankTypes _tank, Material _color)
    {
        movementSpeed = _movementspeed;
        rotationSpeed = _rotationspeed;
        tankTypes = _tank;
        color = _color;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}