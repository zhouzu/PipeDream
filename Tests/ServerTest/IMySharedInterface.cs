﻿namespace ServerTest
{
    public interface IMySharedInterface
    {
        MyObject GetMyRemoteObject(string name, int age, double iq);

        void VoidMethod();
        string NoParameters();
    }
}
