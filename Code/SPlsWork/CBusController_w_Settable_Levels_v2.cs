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

namespace UserModule_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2
{
    public class UserModuleClass_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_1_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_2_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_3_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_4_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_5_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_PRESET_6_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_1_UP_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_2_UP_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_3_UP_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_1_DN_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_2_DN_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_3_DN_BT;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_1_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_2_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_3_TOGGLE;
        Crestron.Logos.SplusObjects.StringInput FROM_CBUS;
        Crestron.Logos.SplusObjects.DigitalOutput LIGHT_TOGGLE_1_FB;
        Crestron.Logos.SplusObjects.DigitalOutput LIGHT_TOGGLE_2_FB;
        Crestron.Logos.SplusObjects.DigitalOutput LIGHT_TOGGLE_3_FB;
        Crestron.Logos.SplusObjects.AnalogOutput LIGHT_LEVEL_1;
        Crestron.Logos.SplusObjects.AnalogOutput LIGHT_LEVEL_2;
        Crestron.Logos.SplusObjects.AnalogOutput LIGHT_LEVEL_3;
        Crestron.Logos.SplusObjects.StringOutput TO_CBUS;
        StringParameter APPLICATION;
        InOutArray<StringParameter> CBUSADDRESSES;
        InOutArray<UShortParameter> PRESET1LEVELS;
        InOutArray<UShortParameter> PRESET2LEVELS;
        InOutArray<UShortParameter> PRESET3LEVELS;
        InOutArray<UShortParameter> PRESET4LEVELS;
        InOutArray<UShortParameter> PRESET5LEVELS;
        InOutArray<UShortParameter> PRESET6LEVELS;
        ushort [,] CPRESETLEVEL;
        ushort NSENDSTRING = 0;
        ushort [] NLIGHTLEVEL;
        CrestronString STRHEADER;
        CrestronString STRMIDDLE;
        CrestronString STRFOOTER;
        CrestronString [] CPRESETSTRINGS;
        private void FNSETUP (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 119;
            STRHEADER  .UpdateValue ( "\u005C05"  ) ; 
            __context__.SourceCodeLine = 120;
            STRMIDDLE  .UpdateValue ( "0002"  ) ; 
            __context__.SourceCodeLine = 121;
            STRFOOTER  .UpdateValue ( "x\u000D"  ) ; 
            __context__.SourceCodeLine = 123;
            CPRESETLEVEL [ 1 , 1] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 124;
            CPRESETLEVEL [ 1 , 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 125;
            CPRESETLEVEL [ 1 , 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 126;
            CPRESETLEVEL [ 1 , 4] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 127;
            CPRESETLEVEL [ 1 , 5] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 128;
            CPRESETLEVEL [ 1 , 6] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 129;
            CPRESETLEVEL [ 1 , 7] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 131;
            CPRESETLEVEL [ 2 , 1] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 132;
            CPRESETLEVEL [ 2 , 2] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 133;
            CPRESETLEVEL [ 2 , 3] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 134;
            CPRESETLEVEL [ 2 , 4] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 135;
            CPRESETLEVEL [ 2 , 5] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 136;
            CPRESETLEVEL [ 2 , 6] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 137;
            CPRESETLEVEL [ 2 , 7] = (ushort) ( 155 ) ; 
            __context__.SourceCodeLine = 139;
            CPRESETLEVEL [ 3 , 1] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 140;
            CPRESETLEVEL [ 3 , 2] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 141;
            CPRESETLEVEL [ 3 , 3] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 142;
            CPRESETLEVEL [ 3 , 4] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 143;
            CPRESETLEVEL [ 3 , 5] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 144;
            CPRESETLEVEL [ 3 , 6] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 145;
            CPRESETLEVEL [ 3 , 7] = (ushort) ( 100 ) ; 
            __context__.SourceCodeLine = 147;
            CPRESETLEVEL [ 4 , 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 148;
            CPRESETLEVEL [ 4 , 2] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 149;
            CPRESETLEVEL [ 4 , 3] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 150;
            CPRESETLEVEL [ 4 , 4] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 151;
            CPRESETLEVEL [ 4 , 5] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 152;
            CPRESETLEVEL [ 4 , 6] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 153;
            CPRESETLEVEL [ 4 , 7] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 155;
            CPRESETLEVEL [ 5 , 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 156;
            CPRESETLEVEL [ 5 , 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 157;
            CPRESETLEVEL [ 5 , 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 158;
            CPRESETLEVEL [ 5 , 4] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 159;
            CPRESETLEVEL [ 5 , 5] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 160;
            CPRESETLEVEL [ 5 , 6] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 161;
            CPRESETLEVEL [ 5 , 7] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 163;
            CPRESETLEVEL [ 6 , 1] = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 164;
            CPRESETLEVEL [ 6 , 2] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 165;
            CPRESETLEVEL [ 6 , 3] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 166;
            CPRESETLEVEL [ 6 , 4] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 167;
            CPRESETLEVEL [ 6 , 5] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 168;
            CPRESETLEVEL [ 6 , 6] = (ushort) ( 255 ) ; 
            __context__.SourceCodeLine = 169;
            CPRESETLEVEL [ 6 , 7] = (ushort) ( 255 ) ; 
            
            }
            
        private void FNDOFEDBACK (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 175;
            LIGHT_LEVEL_1  .Value = (ushort) ( NLIGHTLEVEL[ 1 ] ) ; 
            __context__.SourceCodeLine = 176;
            LIGHT_LEVEL_2  .Value = (ushort) ( NLIGHTLEVEL[ 2 ] ) ; 
            __context__.SourceCodeLine = 177;
            LIGHT_LEVEL_3  .Value = (ushort) ( NLIGHTLEVEL[ 3 ] ) ; 
            __context__.SourceCodeLine = 179;
            if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 1 ])  ) ) 
                {
                __context__.SourceCodeLine = 179;
                LIGHT_TOGGLE_1_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 180;
                LIGHT_TOGGLE_1_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 182;
            if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 2 ])  ) ) 
                {
                __context__.SourceCodeLine = 182;
                LIGHT_TOGGLE_2_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 183;
                LIGHT_TOGGLE_2_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 185;
            if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 3 ])  ) ) 
                {
                __context__.SourceCodeLine = 185;
                LIGHT_TOGGLE_3_FB  .Value = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 186;
                LIGHT_TOGGLE_3_FB  .Value = (ushort) ( 0 ) ; 
                }
            
            
            }
            
        object LIGHTS_PRESET_1_BT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort X = 0;
                
                ushort GETLAST = 0;
                
                
                __context__.SourceCodeLine = 221;
                GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 222;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)3; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 224;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 226;
                        NLIGHTLEVEL [ X] = (ushort) ( PRESET1LEVELS[ X ] .Value ) ; 
                        __context__.SourceCodeLine = 227;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET1LEVELS[ X ] .Value < 10 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 229;
                            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET1LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 233;
                            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET1LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 235;
                        Functions.Delay (  (int) ( 20 ) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 222;
                    } 
                
                __context__.SourceCodeLine = 238;
                FNDOFEDBACK (  __context__  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object LIGHTS_PRESET_2_BT_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            ushort X = 0;
            
            ushort GETLAST = 0;
            
            
            __context__.SourceCodeLine = 244;
            GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 245;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)3; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 247;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 249;
                    NLIGHTLEVEL [ X] = (ushort) ( PRESET2LEVELS[ X ] .Value ) ; 
                    __context__.SourceCodeLine = 250;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET2LEVELS[ X ] .Value < 10 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 252;
                        MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET2LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 256;
                        MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET2LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 258;
                    Functions.Delay (  (int) ( 20 ) ) ; 
                    } 
                
                __context__.SourceCodeLine = 245;
                } 
            
            __context__.SourceCodeLine = 261;
            FNDOFEDBACK (  __context__  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object LIGHTS_PRESET_3_BT_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        ushort GETLAST = 0;
        
        
        __context__.SourceCodeLine = 267;
        GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 268;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 270;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 272;
                NLIGHTLEVEL [ X] = (ushort) ( PRESET3LEVELS[ X ] .Value ) ; 
                __context__.SourceCodeLine = 273;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET3LEVELS[ X ] .Value < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 275;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET3LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 279;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET3LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                __context__.SourceCodeLine = 281;
                Functions.Delay (  (int) ( 20 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 268;
            } 
        
        __context__.SourceCodeLine = 284;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_PRESET_4_BT_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        ushort GETLAST = 0;
        
        
        __context__.SourceCodeLine = 290;
        GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 291;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 293;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 295;
                NLIGHTLEVEL [ X] = (ushort) ( PRESET4LEVELS[ X ] .Value ) ; 
                __context__.SourceCodeLine = 296;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET4LEVELS[ X ] .Value < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 298;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET4LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 302;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET4LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                __context__.SourceCodeLine = 304;
                Functions.Delay (  (int) ( 20 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 291;
            } 
        
        __context__.SourceCodeLine = 307;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_PRESET_5_BT_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        ushort GETLAST = 0;
        
        
        __context__.SourceCodeLine = 313;
        GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 314;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 316;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 318;
                NLIGHTLEVEL [ X] = (ushort) ( PRESET5LEVELS[ X ] .Value ) ; 
                __context__.SourceCodeLine = 319;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET5LEVELS[ X ] .Value < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 321;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET5LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 325;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET5LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                __context__.SourceCodeLine = 327;
                Functions.Delay (  (int) ( 20 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 314;
            } 
        
        __context__.SourceCodeLine = 330;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_PRESET_6_BT_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort X = 0;
        
        ushort GETLAST = 0;
        
        
        __context__.SourceCodeLine = 336;
        GETLAST = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 337;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)3; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( X  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (X  >= __FN_FORSTART_VAL__1) && (X  <= __FN_FOREND_VAL__1) ) : ( (X  <= __FN_FORSTART_VAL__1) && (X  >= __FN_FOREND_VAL__1) ) ; X  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 339;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CBUSADDRESSES[ X ] != ""))  ) ) 
                { 
                __context__.SourceCodeLine = 341;
                NLIGHTLEVEL [ X] = (ushort) ( PRESET6LEVELS[ X ] .Value ) ; 
                __context__.SourceCodeLine = 342;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PRESET6LEVELS[ X ] .Value < 10 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 344;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , "0" , Functions.ItoHex (  (int) ( PRESET6LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 348;
                    MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ X ] , Functions.ItoHex (  (int) ( PRESET6LEVELS[ X ] .Value ) ) , STRFOOTER ) ; 
                    } 
                
                __context__.SourceCodeLine = 350;
                Functions.Delay (  (int) ( 20 ) ) ; 
                } 
            
            __context__.SourceCodeLine = 337;
            } 
        
        __context__.SourceCodeLine = 361;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_1_UP_BT_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 368;
        NLIGHTLEVEL [ 1] = (ushort) ( (NLIGHTLEVEL[ 1 ] + 20) ) ; 
        __context__.SourceCodeLine = 369;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 1 ] > 255 ))  ) ) 
            {
            __context__.SourceCodeLine = 369;
            NLIGHTLEVEL [ 1] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 371;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 1 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 373;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 377;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 380;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_2_UP_BT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 385;
        NLIGHTLEVEL [ 2] = (ushort) ( (NLIGHTLEVEL[ 2 ] + 20) ) ; 
        __context__.SourceCodeLine = 386;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 2 ] > 255 ))  ) ) 
            {
            __context__.SourceCodeLine = 386;
            NLIGHTLEVEL [ 2] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 388;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 2 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 390;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 394;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 397;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_3_UP_BT_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 402;
        NLIGHTLEVEL [ 3] = (ushort) ( (NLIGHTLEVEL[ 3 ] + 20) ) ; 
        __context__.SourceCodeLine = 403;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 3 ] > 255 ))  ) ) 
            {
            __context__.SourceCodeLine = 403;
            NLIGHTLEVEL [ 3] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 405;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 3 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 407;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 411;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 414;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_1_DN_BT_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 419;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 1 ] <= 20 ))  ) ) 
            {
            __context__.SourceCodeLine = 419;
            NLIGHTLEVEL [ 1] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 420;
            NLIGHTLEVEL [ 1] = (ushort) ( (NLIGHTLEVEL[ 1 ] - 20) ) ; 
            }
        
        __context__.SourceCodeLine = 422;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 1 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 424;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 428;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 431;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_2_DN_BT_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 436;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 2 ] <= 20 ))  ) ) 
            {
            __context__.SourceCodeLine = 436;
            NLIGHTLEVEL [ 2] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 437;
            NLIGHTLEVEL [ 2] = (ushort) ( (NLIGHTLEVEL[ 2 ] - 20) ) ; 
            }
        
        __context__.SourceCodeLine = 439;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 2 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 441;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 445;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 448;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_3_DN_BT_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 453;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 3 ] <= 20 ))  ) ) 
            {
            __context__.SourceCodeLine = 453;
            NLIGHTLEVEL [ 3] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 454;
            NLIGHTLEVEL [ 3] = (ushort) ( (NLIGHTLEVEL[ 3 ] - 20) ) ; 
            }
        
        __context__.SourceCodeLine = 456;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 3 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 458;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 462;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 465;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_1_TOGGLE_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 470;
        if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 1 ])  ) ) 
            {
            __context__.SourceCodeLine = 470;
            NLIGHTLEVEL [ 1] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 471;
            NLIGHTLEVEL [ 1] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 472;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 1 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 474;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 478;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 1 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 1 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 481;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_2_TOGGLE_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 486;
        if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 2 ])  ) ) 
            {
            __context__.SourceCodeLine = 486;
            NLIGHTLEVEL [ 2] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 487;
            NLIGHTLEVEL [ 2] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 488;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 2 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 490;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 494;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 2 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 2 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 497;
        FNDOFEDBACK (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_3_TOGGLE_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 503;
        if ( Functions.TestForTrue  ( ( NLIGHTLEVEL[ 3 ])  ) ) 
            {
            __context__.SourceCodeLine = 503;
            NLIGHTLEVEL [ 3] = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 504;
            NLIGHTLEVEL [ 3] = (ushort) ( 255 ) ; 
            }
        
        __context__.SourceCodeLine = 505;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NLIGHTLEVEL[ 3 ] < 10 ))  ) ) 
            { 
            __context__.SourceCodeLine = 507;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}{6}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , "0" , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 511;
            MakeString ( TO_CBUS , "{0}{1}{2}{3}{4}{5}", STRHEADER , APPLICATION , STRMIDDLE , CBUSADDRESSES [ 3 ] , Functions.ItoHex (  (int) ( NLIGHTLEVEL[ 3 ] ) ) , STRFOOTER ) ; 
            } 
        
        __context__.SourceCodeLine = 514;
        FNDOFEDBACK (  __context__  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 588;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 595;
        FNSETUP (  __context__  ) ; 
        
        
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
    NLIGHTLEVEL  = new ushort[ 8 ];
    CPRESETLEVEL  = new ushort[ 7,8 ];
    STRHEADER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    STRMIDDLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    STRFOOTER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    CPRESETSTRINGS  = new CrestronString[ 7 ];
    for( uint i = 0; i < 7; i++ )
        CPRESETSTRINGS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    
    LIGHTS_PRESET_1_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_1_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_1_BT__DigitalInput__, LIGHTS_PRESET_1_BT );
    
    LIGHTS_PRESET_2_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_2_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_2_BT__DigitalInput__, LIGHTS_PRESET_2_BT );
    
    LIGHTS_PRESET_3_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_3_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_3_BT__DigitalInput__, LIGHTS_PRESET_3_BT );
    
    LIGHTS_PRESET_4_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_4_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_4_BT__DigitalInput__, LIGHTS_PRESET_4_BT );
    
    LIGHTS_PRESET_5_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_5_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_5_BT__DigitalInput__, LIGHTS_PRESET_5_BT );
    
    LIGHTS_PRESET_6_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_PRESET_6_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_PRESET_6_BT__DigitalInput__, LIGHTS_PRESET_6_BT );
    
    LIGHTS_1_UP_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_1_UP_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_1_UP_BT__DigitalInput__, LIGHTS_1_UP_BT );
    
    LIGHTS_2_UP_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_2_UP_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_2_UP_BT__DigitalInput__, LIGHTS_2_UP_BT );
    
    LIGHTS_3_UP_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_3_UP_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_3_UP_BT__DigitalInput__, LIGHTS_3_UP_BT );
    
    LIGHTS_1_DN_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_1_DN_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_1_DN_BT__DigitalInput__, LIGHTS_1_DN_BT );
    
    LIGHTS_2_DN_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_2_DN_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_2_DN_BT__DigitalInput__, LIGHTS_2_DN_BT );
    
    LIGHTS_3_DN_BT = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_3_DN_BT__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_3_DN_BT__DigitalInput__, LIGHTS_3_DN_BT );
    
    LIGHTS_1_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_1_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_1_TOGGLE__DigitalInput__, LIGHTS_1_TOGGLE );
    
    LIGHTS_2_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_2_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_2_TOGGLE__DigitalInput__, LIGHTS_2_TOGGLE );
    
    LIGHTS_3_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_3_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_3_TOGGLE__DigitalInput__, LIGHTS_3_TOGGLE );
    
    LIGHT_TOGGLE_1_FB = new Crestron.Logos.SplusObjects.DigitalOutput( LIGHT_TOGGLE_1_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( LIGHT_TOGGLE_1_FB__DigitalOutput__, LIGHT_TOGGLE_1_FB );
    
    LIGHT_TOGGLE_2_FB = new Crestron.Logos.SplusObjects.DigitalOutput( LIGHT_TOGGLE_2_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( LIGHT_TOGGLE_2_FB__DigitalOutput__, LIGHT_TOGGLE_2_FB );
    
    LIGHT_TOGGLE_3_FB = new Crestron.Logos.SplusObjects.DigitalOutput( LIGHT_TOGGLE_3_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( LIGHT_TOGGLE_3_FB__DigitalOutput__, LIGHT_TOGGLE_3_FB );
    
    LIGHT_LEVEL_1 = new Crestron.Logos.SplusObjects.AnalogOutput( LIGHT_LEVEL_1__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LIGHT_LEVEL_1__AnalogSerialOutput__, LIGHT_LEVEL_1 );
    
    LIGHT_LEVEL_2 = new Crestron.Logos.SplusObjects.AnalogOutput( LIGHT_LEVEL_2__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LIGHT_LEVEL_2__AnalogSerialOutput__, LIGHT_LEVEL_2 );
    
    LIGHT_LEVEL_3 = new Crestron.Logos.SplusObjects.AnalogOutput( LIGHT_LEVEL_3__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LIGHT_LEVEL_3__AnalogSerialOutput__, LIGHT_LEVEL_3 );
    
    FROM_CBUS = new Crestron.Logos.SplusObjects.StringInput( FROM_CBUS__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( FROM_CBUS__AnalogSerialInput__, FROM_CBUS );
    
    TO_CBUS = new Crestron.Logos.SplusObjects.StringOutput( TO_CBUS__AnalogSerialOutput__, this );
    m_StringOutputList.Add( TO_CBUS__AnalogSerialOutput__, TO_CBUS );
    
    PRESET1LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET1LEVELS[i+1] = new UShortParameter( PRESET1LEVELS__Parameter__ + i, PRESET1LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET1LEVELS__Parameter__ + i, PRESET1LEVELS[i+1] );
    }
    
    PRESET2LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET2LEVELS[i+1] = new UShortParameter( PRESET2LEVELS__Parameter__ + i, PRESET2LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET2LEVELS__Parameter__ + i, PRESET2LEVELS[i+1] );
    }
    
    PRESET3LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET3LEVELS[i+1] = new UShortParameter( PRESET3LEVELS__Parameter__ + i, PRESET3LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET3LEVELS__Parameter__ + i, PRESET3LEVELS[i+1] );
    }
    
    PRESET4LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET4LEVELS[i+1] = new UShortParameter( PRESET4LEVELS__Parameter__ + i, PRESET4LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET4LEVELS__Parameter__ + i, PRESET4LEVELS[i+1] );
    }
    
    PRESET5LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET5LEVELS[i+1] = new UShortParameter( PRESET5LEVELS__Parameter__ + i, PRESET5LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET5LEVELS__Parameter__ + i, PRESET5LEVELS[i+1] );
    }
    
    PRESET6LEVELS = new InOutArray<UShortParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        PRESET6LEVELS[i+1] = new UShortParameter( PRESET6LEVELS__Parameter__ + i, PRESET6LEVELS__Parameter__, this );
        m_ParameterList.Add( PRESET6LEVELS__Parameter__ + i, PRESET6LEVELS[i+1] );
    }
    
    APPLICATION = new StringParameter( APPLICATION__Parameter__, this );
    m_ParameterList.Add( APPLICATION__Parameter__, APPLICATION );
    
    CBUSADDRESSES = new InOutArray<StringParameter>( 7, this );
    for( uint i = 0; i < 7; i++ )
    {
        CBUSADDRESSES[i+1] = new StringParameter( CBUSADDRESSES__Parameter__ + i, CBUSADDRESSES__Parameter__, this );
        m_ParameterList.Add( CBUSADDRESSES__Parameter__ + i, CBUSADDRESSES[i+1] );
    }
    
    
    LIGHTS_PRESET_1_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_1_BT_OnPush_0, false ) );
    LIGHTS_PRESET_2_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_2_BT_OnPush_1, false ) );
    LIGHTS_PRESET_3_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_3_BT_OnPush_2, false ) );
    LIGHTS_PRESET_4_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_4_BT_OnPush_3, false ) );
    LIGHTS_PRESET_5_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_5_BT_OnPush_4, false ) );
    LIGHTS_PRESET_6_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_PRESET_6_BT_OnPush_5, false ) );
    LIGHTS_1_UP_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_1_UP_BT_OnPush_6, false ) );
    LIGHTS_2_UP_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_2_UP_BT_OnPush_7, false ) );
    LIGHTS_3_UP_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_3_UP_BT_OnPush_8, false ) );
    LIGHTS_1_DN_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_1_DN_BT_OnPush_9, false ) );
    LIGHTS_2_DN_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_2_DN_BT_OnPush_10, false ) );
    LIGHTS_3_DN_BT.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_3_DN_BT_OnPush_11, false ) );
    LIGHTS_1_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_1_TOGGLE_OnPush_12, false ) );
    LIGHTS_2_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_2_TOGGLE_OnPush_13, false ) );
    LIGHTS_3_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_3_TOGGLE_OnPush_14, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint LIGHTS_PRESET_1_BT__DigitalInput__ = 0;
const uint LIGHTS_PRESET_2_BT__DigitalInput__ = 1;
const uint LIGHTS_PRESET_3_BT__DigitalInput__ = 2;
const uint LIGHTS_PRESET_4_BT__DigitalInput__ = 3;
const uint LIGHTS_PRESET_5_BT__DigitalInput__ = 4;
const uint LIGHTS_PRESET_6_BT__DigitalInput__ = 5;
const uint LIGHTS_1_UP_BT__DigitalInput__ = 6;
const uint LIGHTS_2_UP_BT__DigitalInput__ = 7;
const uint LIGHTS_3_UP_BT__DigitalInput__ = 8;
const uint LIGHTS_1_DN_BT__DigitalInput__ = 9;
const uint LIGHTS_2_DN_BT__DigitalInput__ = 10;
const uint LIGHTS_3_DN_BT__DigitalInput__ = 11;
const uint LIGHTS_1_TOGGLE__DigitalInput__ = 12;
const uint LIGHTS_2_TOGGLE__DigitalInput__ = 13;
const uint LIGHTS_3_TOGGLE__DigitalInput__ = 14;
const uint FROM_CBUS__AnalogSerialInput__ = 0;
const uint LIGHT_TOGGLE_1_FB__DigitalOutput__ = 0;
const uint LIGHT_TOGGLE_2_FB__DigitalOutput__ = 1;
const uint LIGHT_TOGGLE_3_FB__DigitalOutput__ = 2;
const uint LIGHT_LEVEL_1__AnalogSerialOutput__ = 0;
const uint LIGHT_LEVEL_2__AnalogSerialOutput__ = 1;
const uint LIGHT_LEVEL_3__AnalogSerialOutput__ = 2;
const uint TO_CBUS__AnalogSerialOutput__ = 3;
const uint APPLICATION__Parameter__ = 10;
const uint CBUSADDRESSES__Parameter__ = 11;
const uint PRESET1LEVELS__Parameter__ = 18;
const uint PRESET2LEVELS__Parameter__ = 25;
const uint PRESET3LEVELS__Parameter__ = 32;
const uint PRESET4LEVELS__Parameter__ = 39;
const uint PRESET5LEVELS__Parameter__ = 46;
const uint PRESET6LEVELS__Parameter__ = 53;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
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
