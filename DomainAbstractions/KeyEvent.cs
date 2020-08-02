﻿﻿using System;
using System.Windows.Input;
using Libraries;
using ProgrammingParadigms;

namespace DomainAbstractions
{
    /// <summary>
    /// <para>Subscribes a KeyEventHandler to an IEventHandler with a user-specified lambda, and propagates the sender, args, and event (as an IEvent) as outputs.</para>
    /// <para>The Lambda definition should follow the following format:<code>Lambda = (sender, args) => { ... }</code></para>
    /// </summary>
    public class KeyEvent : IEventHandler
    {
        // Public fields and properties
        public string InstanceName = "Default";
        public KeyEventHandler Lambda;

        // Private fields
        private string eventToHandle;
        private object _sender;

        // Ports
        private IDataFlow<object> senderOutput;
        private IDataFlow<KeyEventArgs> argsOutput;
        private IEvent eventHappened;

        /// <summary>
        /// <para>Subscribes a KeyEventHandler to an IEventHandler with a user-specified lambda, and propagates the sender, args, and event (as an IEvent) as outputs.</para>
        /// <para>The Lambda definition should follow the following format:<code>Lambda = (sender, args) => { ... }</code></para>
        /// </summary>
        public KeyEvent(string eventName)
        {
            eventToHandle = eventName;
        }

        // IEventHandler<T> implementation
        public object Sender
        {
            get => _sender;
            set
            {
                _sender = value;
                Subscribe(eventToHandle, _sender);
            }
        }

        public void Subscribe(string eventName, object sender)
        {
            var senderType = sender.GetType();
            var senderEvent = senderType.GetEvent(eventName);

            try
            {
                // Subscribe the user-specified lambda
                if (Lambda != null) senderEvent.AddEventHandler(sender, Lambda);

                // Propagate the sender, args, and event (as an IEvent) after the event has been handled by the user-specified lambda
                senderEvent.AddEventHandler(sender, new KeyEventHandler((o, args) =>
                {
                    if (senderOutput != null) senderOutput.Data = sender;
                    if (argsOutput != null) argsOutput.Data = args;
                    eventHappened?.Execute();
                }));
                
            }
            catch (Exception e)
            {

            }
        }
    }
}
