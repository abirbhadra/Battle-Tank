using UnityEngine;

public class TankModel
{
    private TankController tankController;

    public float movementSpeed;
    public float rotationSpeed;

    public TankModel(float _movementspeed, float _rotationspeed)
    {
        movementSpeed = _movementspeed;
        rotationSpeed = _rotationspeed;
    }

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }
}