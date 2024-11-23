//using system.collections;
//using system.collections.generic;
//using unityengine;

//public class player : monobehaviour
//{
//    [serializefield] private float speed;
//    [serializefield] private string inputnamehorizontal;
//    [serializefield] private string inputnamevertical;

//    [serializefield] private color color;

//    private rigidbody rb;
//    private renderer renderer;

//    private float inputhorizontal;
//    private float inputvertical;

//    private void start()
//    {
//        rb = getcomponent<rigidbody>();
//        renderer = getcomponentinchildren<renderer>();
//        renderer.material.color = color;
//    }

//    private void update()
//    {
//        inputhorizontal = input.getaxisraw(inputnamehorizontal);
//        inputvertical = input.getaxisraw(inputnamevertical);
//    }

//    private void fixedupdate()
//    {
//        rb.linearvelocity = new vector3(inputhorizontal * speed * time.fixeddeltatime, rb.linearvelocity.y, inputvertical * speed * time.fixeddeltatime);
//    }
//}
