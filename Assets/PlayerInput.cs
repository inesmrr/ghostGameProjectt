using Fusion;

public class PlayerInput : NetworkBehaviour
{
  private NetworkCharacterControllerPrototype _cc;

  private void Awake()
  {
    _cc = GetComponent<NetworkCharacterControllerPrototype>();
  }

  public override void FixedUpdateNetwork()
  {

    var check = new BasicSpawner();

    if (GetInput(out NetworkInputData data))
    {
      data.direction.Normalize();
      _cc.Move(5*data.direction*Runner.DeltaTime);
    }

    if ((data.buttons & NetworkInputData.MOUSEBUTTON1) != 0)
    {
      _cc.Jump(false);
    }
  }
}
