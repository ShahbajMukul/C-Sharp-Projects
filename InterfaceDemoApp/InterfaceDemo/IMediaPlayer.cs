using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{

    // interface is a contract that defines a set of methods that a class must implement. 
    public interface IMediaPlayer
    {
        void Play();
        void Pause();
        void Stop();
        (string name, double length) NowPlaying();
    }
/*
    INTERFACE USAGE SUMMARY:
     
     1. Abstraction and Encapsulation:
        - Interfaces define a contract without implementation details.
        - Encourages hiding internal workings, enhancing code clarity.
     
     2. Flexibility and Extensibility:
        - Adaptable to change: Modify behavior centrally by updating the interface.
        - Avoids making changes in every individual class.
     
     3. Polymorphism and Dependency Injection:
        - Treat different classes implementing an interface as the same type.
        - Promotes modularity and easier testing.
     
     4. Multiple Inheritance(for Interfaces):
        - A class can implement multiple interfaces, combining different functionalities.
        - Overcomes single inheritance limitations.
     
     5. Clear Contracts:
        - Interfaces define expected methods, clarifying class behaviors.
        - Beneficial for team projects and larger codebases.

     While using interfaces adds initial code, the long-term benefits
     in terms of maintainable, scalable, and organized code are significant.
     A valuable tool for building robust software.

     Feel free to explore more examples and ask questions!
*/

}
