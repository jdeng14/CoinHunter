Greetings!

  Thanks for purchasing our asset pack! This readme provides detailed information about it's contents, as well as some hints on how to setup your animation based destruction in unity.

  Our pack consists of 13 prefabs, with one diffuse-only material. Assets barrel, barrel02, crate, pot, pot02, sack and sack02 have animation-based destruction.
Destructible objects work basically like this: each object with a destruction, has a collider and a ColliderCheck script assigned to it, which kills the object upon collision and swaps it with the _crush version, that has 2 animations, which play randomly using the RandomAnimPlayer script. 

  There are two required conditions to perform destruction:
1) The destructible objects, as well as the object that initiates the destruction (let's call it the Initiator) must have "crushObj" tag assigned to them 
2) At least one of objects (destructible object or Initiator) should have Rigidbody component  

Here is a step-by-step on how to setup your destruction in a clean scene:
1) Create a plane (GameObject – Create Other – Plane)
2) Drag and drop any destructible object on scene.
3) Create a cube ( GameObject – Create Other – Cube), make sure it is above the object
4) Assign crushObj tag, and RigidBody script on the cube.
5) Click Play. The box will fall down on the object and destroy it.

Hope you enjoy this pack!

Best regards,
Busina team.