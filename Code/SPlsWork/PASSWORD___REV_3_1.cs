using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_PASSWORD___REV_3_1
{
    public class UserModuleClass_PASSWORD___REV_3_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput KEY1;
        Crestron.Logos.SplusObjects.DigitalInput KEY2;
        Crestron.Logos.SplusObjects.DigitalInput KEY3;
        Crestron.Logos.SplusObjects.DigitalInput KEY4;
        Crestron.Logos.SplusObjects.DigitalInput KEY5;
        Crestron.Logos.SplusObjects.DigitalInput KEY6;
        Crestron.Logos.SplusObjects.DigitalInput KEY7;
        Crestron.Logos.SplusObjects.DigitalInput KEY8;
        Crestron.Logos.SplusObjects.DigitalInput KEY9;
        Crestron.Logos.SplusObjects.DigitalInput KEY0;
        Crestron.Logos.SplusObjects.DigitalInput KEYSTAR;
        Crestron.Logos.SplusObjects.DigitalInput KEYHASH;
        Crestron.Logos.SplusObjects.DigitalInput KEYDOT;
        Crestron.Logos.SplusObjects.DigitalInput KEYPAUSE;
        Crestron.Logos.SplusObjects.DigitalInput CLEAR;
        Crestron.Logos.SplusObjects.DigitalInput BACKSPACE;
        Crestron.Logos.SplusObjects.DigitalInput ENTER;
        Crestron.Logos.SplusObjects.DigitalInput AUTO_CHECK_EN;
        Crestron.Logos.SplusObjects.StringInput CODE;
        Crestron.Logos.SplusObjects.StringInput CODE2;
        Crestron.Logos.SplusObjects.StringInput CODE3;
        Crestron.Logos.SplusObjects.StringInput ADMIN_CODE;
        Crestron.Logos.SplusObjects.DigitalOutput CODE1GOOD;
        Crestron.Logos.SplusObjects.DigitalOutput CODE2GOOD;
        Crestron.Logos.SplusObjects.DigitalOutput CODE3GOOD;
        Crestron.Logos.SplusObjects.DigitalOutput ADMIN;
        Crestron.Logos.SplusObjects.DigitalOutput ERROR;
        Crestron.Logos.SplusObjects.StringOutput SPASSCODE;
        Crestron.Logos.SplusObjects.StringOutput SPASSCODE_STARS;
        private void STARS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 84;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)Functions.Length( _SplusNVRAM.PASSCODE ));
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 86;
                        SPASSCODE_STARS  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 87;
                        SPASSCODE_STARS  .UpdateValue ( "*"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 88;
                        SPASSCODE_STARS  .UpdateValue ( "**"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 89;
                        SPASSCODE_STARS  .UpdateValue ( "***"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 90;
                        SPASSCODE_STARS  .UpdateValue ( "****"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 91;
                        SPASSCODE_STARS  .UpdateValue ( "*****"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 92;
                        SPASSCODE_STARS  .UpdateValue ( "******"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 93;
                        SPASSCODE_STARS  .UpdateValue ( "*******"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 94;
                        SPASSCODE_STARS  .UpdateValue ( "********"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 9) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 95;
                        SPASSCODE_STARS  .UpdateValue ( "*********"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 96;
                        SPASSCODE_STARS  .UpdateValue ( "**********"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 97;
                        SPASSCODE_STARS  .UpdateValue ( "***********"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 98;
                        SPASSCODE_STARS  .UpdateValue ( "************"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 99;
                        SPASSCODE_STARS  .UpdateValue ( "*************"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 100;
                        SPASSCODE_STARS  .UpdateValue ( "**************"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 101;
                        SPASSCODE_STARS  .UpdateValue ( "***************"  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void CHECKPASSCODE (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 108;
            if ( Functions.TestForTrue  ( ( Functions.Find( CODE , _SplusNVRAM.PASSCODE , 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 110;
                Functions.Pulse ( 100, CODE1GOOD ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 113;
                if ( Functions.TestForTrue  ( ( Functions.Find( CODE2 , _SplusNVRAM.PASSCODE , 1 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 115;
                    Functions.Pulse ( 100, CODE2GOOD ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 119;
                    if ( Functions.TestForTrue  ( ( Functions.Find( CODE3 , _SplusNVRAM.PASSCODE , 1 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 121;
                        Functions.Pulse ( 100, CODE3GOOD ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 125;
                        if ( Functions.TestForTrue  ( ( Functions.Find( ADMIN_CODE , _SplusNVRAM.PASSCODE , 1 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 127;
                            Functions.Pulse ( 100, ADMIN ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 131;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 0))  ) ) 
                                {
                                __context__.SourceCodeLine = 132;
                                Functions.Pulse ( 100, ERROR ) ; 
                                }
                            
                            } 
                        
                        }
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 137;
            STARS (  __context__  ) ; 
            
            }
            
        object KEY1_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 148;
                _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "1"  ) ; 
                __context__.SourceCodeLine = 149;
                SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
                __context__.SourceCodeLine = 150;
                STARS (  __context__  ) ; 
                __context__.SourceCodeLine = 151;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
                    {
                    __context__.SourceCodeLine = 152;
                    CHECKPASSCODE (  __context__  ) ; 
                    }
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object KEY2_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 157;
            _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "2"  ) ; 
            __context__.SourceCodeLine = 158;
            SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
            __context__.SourceCodeLine = 159;
            STARS (  __context__  ) ; 
            __context__.SourceCodeLine = 160;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
                {
                __context__.SourceCodeLine = 161;
                CHECKPASSCODE (  __context__  ) ; 
                }
            
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object KEY3_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 166;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "3"  ) ; 
        __context__.SourceCodeLine = 167;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 168;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 169;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 170;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY4_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 175;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "4"  ) ; 
        __context__.SourceCodeLine = 176;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 177;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 178;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 179;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY5_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 184;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "5"  ) ; 
        __context__.SourceCodeLine = 185;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 186;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 187;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 188;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY6_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 193;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "6"  ) ; 
        __context__.SourceCodeLine = 194;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 195;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 196;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 197;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY7_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 202;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "7"  ) ; 
        __context__.SourceCodeLine = 203;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 204;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 205;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 206;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY8_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 211;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "8"  ) ; 
        __context__.SourceCodeLine = 212;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 213;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 214;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 215;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY9_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 220;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "9"  ) ; 
        __context__.SourceCodeLine = 221;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 222;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 223;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 224;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY0_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 229;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "0"  ) ; 
        __context__.SourceCodeLine = 230;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 231;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 232;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 233;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYSTAR_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 238;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "*"  ) ; 
        __context__.SourceCodeLine = 239;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 240;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 241;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 242;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYHASH_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 247;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "#"  ) ; 
        __context__.SourceCodeLine = 248;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 249;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 250;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 251;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYDOT_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 256;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + "."  ) ; 
        __context__.SourceCodeLine = 257;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 258;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 259;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 260;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYPAUSE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 266;
        _SplusNVRAM.PASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE + ","  ) ; 
        __context__.SourceCodeLine = 267;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 268;
        STARS (  __context__  ) ; 
        __context__.SourceCodeLine = 269;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_SplusNVRAM.IAUTOEN == 1))  ) ) 
            {
            __context__.SourceCodeLine = 270;
            CHECKPASSCODE (  __context__  ) ; 
            }
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLEAR_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 275;
        _SplusNVRAM.PASSCODE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 276;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 277;
        STARS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BACKSPACE_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 283;
        _SplusNVRAM.PASSCODE  .UpdateValue ( Functions.Left ( _SplusNVRAM.PASSCODE ,  (int) ( (Functions.Length( _SplusNVRAM.PASSCODE ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 284;
        SPASSCODE  .UpdateValue ( _SplusNVRAM.PASSCODE  ) ; 
        __context__.SourceCodeLine = 285;
        STARS (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ENTER_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 290;
        CHECKPASSCODE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_CHECK_EN_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 295;
        _SplusNVRAM.IAUTOEN = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AUTO_CHECK_EN_OnRelease_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 300;
        _SplusNVRAM.IAUTOEN = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 311;
        _SplusNVRAM.PASSCODE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 312;
        SPASSCODE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 313;
        SPASSCODE_STARS  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 314;
        _SplusNVRAM.IAUTOEN = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 316;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    SocketInfo __socketinfo__ = new SocketInfo( 1, this );
    InitialParametersClass.ResolveHostName = __socketinfo__.ResolveHostName;
    _SplusNVRAM = new SplusNVRAM( this );
    _SplusNVRAM.PASSCODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    
    KEY1 = new Crestron.Logos.SplusObjects.DigitalInput( KEY1__DigitalInput__, this );
    m_DigitalInputList.Add( KEY1__DigitalInput__, KEY1 );
    
    KEY2 = new Crestron.Logos.SplusObjects.DigitalInput( KEY2__DigitalInput__, this );
    m_DigitalInputList.Add( KEY2__DigitalInput__, KEY2 );
    
    KEY3 = new Crestron.Logos.SplusObjects.DigitalInput( KEY3__DigitalInput__, this );
    m_DigitalInputList.Add( KEY3__DigitalInput__, KEY3 );
    
    KEY4 = new Crestron.Logos.SplusObjects.DigitalInput( KEY4__DigitalInput__, this );
    m_DigitalInputList.Add( KEY4__DigitalInput__, KEY4 );
    
    KEY5 = new Crestron.Logos.SplusObjects.DigitalInput( KEY5__DigitalInput__, this );
    m_DigitalInputList.Add( KEY5__DigitalInput__, KEY5 );
    
    KEY6 = new Crestron.Logos.SplusObjects.DigitalInput( KEY6__DigitalInput__, this );
    m_DigitalInputList.Add( KEY6__DigitalInput__, KEY6 );
    
    KEY7 = new Crestron.Logos.SplusObjects.DigitalInput( KEY7__DigitalInput__, this );
    m_DigitalInputList.Add( KEY7__DigitalInput__, KEY7 );
    
    KEY8 = new Crestron.Logos.SplusObjects.DigitalInput( KEY8__DigitalInput__, this );
    m_DigitalInputList.Add( KEY8__DigitalInput__, KEY8 );
    
    KEY9 = new Crestron.Logos.SplusObjects.DigitalInput( KEY9__DigitalInput__, this );
    m_DigitalInputList.Add( KEY9__DigitalInput__, KEY9 );
    
    KEY0 = new Crestron.Logos.SplusObjects.DigitalInput( KEY0__DigitalInput__, this );
    m_DigitalInputList.Add( KEY0__DigitalInput__, KEY0 );
    
    KEYSTAR = new Crestron.Logos.SplusObjects.DigitalInput( KEYSTAR__DigitalInput__, this );
    m_DigitalInputList.Add( KEYSTAR__DigitalInput__, KEYSTAR );
    
    KEYHASH = new Crestron.Logos.SplusObjects.DigitalInput( KEYHASH__DigitalInput__, this );
    m_DigitalInputList.Add( KEYHASH__DigitalInput__, KEYHASH );
    
    KEYDOT = new Crestron.Logos.SplusObjects.DigitalInput( KEYDOT__DigitalInput__, this );
    m_DigitalInputList.Add( KEYDOT__DigitalInput__, KEYDOT );
    
    KEYPAUSE = new Crestron.Logos.SplusObjects.DigitalInput( KEYPAUSE__DigitalInput__, this );
    m_DigitalInputList.Add( KEYPAUSE__DigitalInput__, KEYPAUSE );
    
    CLEAR = new Crestron.Logos.SplusObjects.DigitalInput( CLEAR__DigitalInput__, this );
    m_DigitalInputList.Add( CLEAR__DigitalInput__, CLEAR );
    
    BACKSPACE = new Crestron.Logos.SplusObjects.DigitalInput( BACKSPACE__DigitalInput__, this );
    m_DigitalInputList.Add( BACKSPACE__DigitalInput__, BACKSPACE );
    
    ENTER = new Crestron.Logos.SplusObjects.DigitalInput( ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( ENTER__DigitalInput__, ENTER );
    
    AUTO_CHECK_EN = new Crestron.Logos.SplusObjects.DigitalInput( AUTO_CHECK_EN__DigitalInput__, this );
    m_DigitalInputList.Add( AUTO_CHECK_EN__DigitalInput__, AUTO_CHECK_EN );
    
    CODE1GOOD = new Crestron.Logos.SplusObjects.DigitalOutput( CODE1GOOD__DigitalOutput__, this );
    m_DigitalOutputList.Add( CODE1GOOD__DigitalOutput__, CODE1GOOD );
    
    CODE2GOOD = new Crestron.Logos.SplusObjects.DigitalOutput( CODE2GOOD__DigitalOutput__, this );
    m_DigitalOutputList.Add( CODE2GOOD__DigitalOutput__, CODE2GOOD );
    
    CODE3GOOD = new Crestron.Logos.SplusObjects.DigitalOutput( CODE3GOOD__DigitalOutput__, this );
    m_DigitalOutputList.Add( CODE3GOOD__DigitalOutput__, CODE3GOOD );
    
    ADMIN = new Crestron.Logos.SplusObjects.DigitalOutput( ADMIN__DigitalOutput__, this );
    m_DigitalOutputList.Add( ADMIN__DigitalOutput__, ADMIN );
    
    ERROR = new Crestron.Logos.SplusObjects.DigitalOutput( ERROR__DigitalOutput__, this );
    m_DigitalOutputList.Add( ERROR__DigitalOutput__, ERROR );
    
    CODE = new Crestron.Logos.SplusObjects.StringInput( CODE__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( CODE__AnalogSerialInput__, CODE );
    
    CODE2 = new Crestron.Logos.SplusObjects.StringInput( CODE2__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( CODE2__AnalogSerialInput__, CODE2 );
    
    CODE3 = new Crestron.Logos.SplusObjects.StringInput( CODE3__AnalogSerialInput__, 10, this );
    m_StringInputList.Add( CODE3__AnalogSerialInput__, CODE3 );
    
    ADMIN_CODE = new Crestron.Logos.SplusObjects.StringInput( ADMIN_CODE__AnalogSerialInput__, 15, this );
    m_StringInputList.Add( ADMIN_CODE__AnalogSerialInput__, ADMIN_CODE );
    
    SPASSCODE = new Crestron.Logos.SplusObjects.StringOutput( SPASSCODE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SPASSCODE__AnalogSerialOutput__, SPASSCODE );
    
    SPASSCODE_STARS = new Crestron.Logos.SplusObjects.StringOutput( SPASSCODE_STARS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( SPASSCODE_STARS__AnalogSerialOutput__, SPASSCODE_STARS );
    
    
    KEY1.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY1_OnPush_0, false ) );
    KEY2.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY2_OnPush_1, false ) );
    KEY3.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY3_OnPush_2, false ) );
    KEY4.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY4_OnPush_3, false ) );
    KEY5.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY5_OnPush_4, false ) );
    KEY6.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY6_OnPush_5, false ) );
    KEY7.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY7_OnPush_6, false ) );
    KEY8.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY8_OnPush_7, false ) );
    KEY9.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY9_OnPush_8, false ) );
    KEY0.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY0_OnPush_9, false ) );
    KEYSTAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYSTAR_OnPush_10, false ) );
    KEYHASH.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYHASH_OnPush_11, false ) );
    KEYDOT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYDOT_OnPush_12, false ) );
    KEYPAUSE.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYPAUSE_OnPush_13, false ) );
    CLEAR.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLEAR_OnPush_14, false ) );
    BACKSPACE.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACKSPACE_OnPush_15, false ) );
    ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( ENTER_OnPush_16, false ) );
    AUTO_CHECK_EN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AUTO_CHECK_EN_OnPush_17, false ) );
    AUTO_CHECK_EN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( AUTO_CHECK_EN_OnRelease_18, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_PASSWORD___REV_3_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint KEY1__DigitalInput__ = 0;
const uint KEY2__DigitalInput__ = 1;
const uint KEY3__DigitalInput__ = 2;
const uint KEY4__DigitalInput__ = 3;
const uint KEY5__DigitalInput__ = 4;
const uint KEY6__DigitalInput__ = 5;
const uint KEY7__DigitalInput__ = 6;
const uint KEY8__DigitalInput__ = 7;
const uint KEY9__DigitalInput__ = 8;
const uint KEY0__DigitalInput__ = 9;
const uint KEYSTAR__DigitalInput__ = 10;
const uint KEYHASH__DigitalInput__ = 11;
const uint KEYDOT__DigitalInput__ = 12;
const uint KEYPAUSE__DigitalInput__ = 13;
const uint CLEAR__DigitalInput__ = 14;
const uint BACKSPACE__DigitalInput__ = 15;
const uint ENTER__DigitalInput__ = 16;
const uint AUTO_CHECK_EN__DigitalInput__ = 17;
const uint CODE__AnalogSerialInput__ = 0;
const uint CODE2__AnalogSerialInput__ = 1;
const uint CODE3__AnalogSerialInput__ = 2;
const uint ADMIN_CODE__AnalogSerialInput__ = 3;
const uint CODE1GOOD__DigitalOutput__ = 0;
const uint CODE2GOOD__DigitalOutput__ = 1;
const uint CODE3GOOD__DigitalOutput__ = 2;
const uint ADMIN__DigitalOutput__ = 3;
const uint ERROR__DigitalOutput__ = 4;
const uint SPASSCODE__AnalogSerialOutput__ = 0;
const uint SPASSCODE_STARS__AnalogSerialOutput__ = 1;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort IAUTOEN = 0;
            [SplusStructAttribute(1, false, true)]
            public CrestronString PASSCODE;
            
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}


}
