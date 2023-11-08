using System;
namespace Patterns.Behavioral.Mediator.Chatroom;

internal class Participant{
    
  private Chatroom _chatroom;
   private string _name;

   public List<Message> Inbox  = new();
   public List<Message> Outbox = new();
 public Participant(string name) {
      _name = name;
    }
 
 public string Name=> _name; 
   
 public Chatroom Chatroom{
      set { _chatroom = value; }
      get { return _chatroom; }
    }
 
 public void Send(string to, string message) {
      _chatroom.Send(_name, to, message);
      Outbox.Add(new Message(_name,to,message));
    }

 public virtual void Receive(string from, string message) {
   Inbox.Add(new Message(from,Name,message));   
    }
  }
  
public class  Message{
  public Message(string from, string to, string message ) {
    this.from = from;
    this.to = to;
    this.message = message;
  }
  public readonly string from;
  public readonly string to;
  public readonly string message;
}