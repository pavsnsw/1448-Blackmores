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

namespace UserModule_SAMSUNG_EXTRA_ID_V1_3
{
    public class UserModuleClass_SAMSUNG_EXTRA_ID_V1_3 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSERIAL;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTSOFTWAREVER;
        Crestron.Logos.SplusObjects.DigitalInput REQUESTMAINTENANCEINFO;
        Crestron.Logos.SplusObjects.DigitalInput LCD_STATUS_REQ;
        Crestron.Logos.SplusObjects.DigitalInput LCD_PANEL_RUNTIME;
        Crestron.Logos.SplusObjects.DigitalInput KEY_MENU;
        Crestron.Logos.SplusObjects.DigitalInput KEY_RETURN;
        Crestron.Logos.SplusObjects.DigitalInput KEY_ENTER;
        Crestron.Logos.SplusObjects.DigitalInput KEY_UP;
        Crestron.Logos.SplusObjects.DigitalInput KEY_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput KEY_LEFT;
        Crestron.Logos.SplusObjects.DigitalInput KEY_RIGHT;
        Crestron.Logos.SplusObjects.DigitalInput KEY_TOOLS;
        Crestron.Logos.SplusObjects.DigitalInput KEY_EXIT;
        Crestron.Logos.SplusObjects.DigitalInput LCD_POWER_ON;
        Crestron.Logos.SplusObjects.DigitalInput LCD_POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_HDMI1;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_HDMI2;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_HDMI3;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_DVI;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_DPORT;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_VGA;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_DTV;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_PIM;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_HDBASET;
        Crestron.Logos.SplusObjects.DigitalInput INPUT_MAGICINFO;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput MUTE;
        Crestron.Logos.SplusObjects.DigitalInput UNMUTE;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput VOL_RESET;
        Crestron.Logos.SplusObjects.DigitalInput CHANNEL_UP;
        Crestron.Logos.SplusObjects.DigitalInput CHANNEL_DOWN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KEY_NUMBER;
        Crestron.Logos.SplusObjects.AnalogInput LCD_ID;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_DEFAULT;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_SLIDER_DRIVE;
        Crestron.Logos.SplusObjects.AnalogInput TV_CHANNEL;
        Crestron.Logos.SplusObjects.BufferInput LCD_RXD__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput LCD_IS_ON;
        Crestron.Logos.SplusObjects.DigitalOutput LCD_IS_RESPONDING;
        Crestron.Logos.SplusObjects.DigitalOutput LCD_MUTE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput LCDTEMPERATURE;
        Crestron.Logos.SplusObjects.AnalogOutput LCDCURRENTINPUT;
        Crestron.Logos.SplusObjects.AnalogOutput LCDRUNTIME;
        Crestron.Logos.SplusObjects.AnalogOutput LCDVOLUMELEVEL;
        Crestron.Logos.SplusObjects.StringOutput LCD_TXD__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput LCD_SERIAL;
        Crestron.Logos.SplusObjects.StringOutput LCD_SOFTWARE;
        ushort IBUSY = 0;
        ushort LASTCOMMAND = 0;
        ushort ILOOP = 0;
        ushort ITEMP = 0;
        ushort ICON = 0;
        ushort ICOUNT = 0;
        ushort ITEMPERATURE = 0;
        ushort IPOWER = 0;
        ushort IINPUT = 0;
        ushort IID = 0;
        ushort ICH = 0;
        ushort IPOWERREQ = 0;
        ushort IRUNTIME = 0;
        ushort IVOLUME = 0;
        ushort IMUTE = 0;
        CrestronString SSERIALN;
        CrestronString SSOFTWARE;
        CrestronString STEMP;
        CrestronString STRASH;
        CrestronString SID;
        CrestronString SID2;
        CrestronString SBUILD;
        private CrestronString ADDCSTOSTRING (  SplusExecutionContext __context__, CrestronString STRINGSEND ) 
            { 
            ushort A = 0;
            ushort ICS = 0;
            ushort ILENGTH = 0;
            
            CrestronString SSTRINGFINAL;
            CrestronString SSTRINGTEMP;
            SSTRINGFINAL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            SSTRINGTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 136;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( "\u00AA" , STRINGSEND ) > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 138;
                ILENGTH = (ushort) ( Functions.Length( STRINGSEND ) ) ; 
                __context__.SourceCodeLine = 139;
                SSTRINGTEMP  .UpdateValue ( Functions.Mid ( STRINGSEND ,  (int) ( 2 ) ,  (int) ( (ILENGTH - 1) ) )  ) ; 
                __context__.SourceCodeLine = 141;
                ICS = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 142;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( SSTRINGTEMP ); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( A  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (A  >= __FN_FORSTART_VAL__1) && (A  <= __FN_FOREND_VAL__1) ) : ( (A  <= __FN_FORSTART_VAL__1) && (A  >= __FN_FOREND_VAL__1) ) ; A  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 144;
                    ICS = (ushort) ( (ICS + Byte( SSTRINGTEMP , (int)( A ) )) ) ; 
                    __context__.SourceCodeLine = 142;
                    } 
                
                __context__.SourceCodeLine = 149;
                SSTRINGFINAL  .UpdateValue ( STRINGSEND + Functions.Chr (  (int) ( ICS ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 151;
            return ( SSTRINGFINAL ) ; 
            
            }
            
        private void POWERSTATUSCOMP (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 156;
            
                {
                int __SPLS_TMPVAR__SWTCH_1__ = ((int)IPOWER);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 160;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOWERREQ == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 162;
                            MakeString ( SBUILD , "\u00AA\u0011{0}\u0001\u0001", SID ) ; 
                            __context__.SourceCodeLine = 163;
                            LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 168;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IPOWERREQ == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 170;
                            MakeString ( SBUILD , "\u00AA\u0011{0}\u0001\u0000", SID ) ; 
                            __context__.SourceCodeLine = 171;
                            LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
                            } 
                        
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        private void RESETVOLUME (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 179;
            IVOLUME = (ushort) ( (VOLUME_DEFAULT  .UshortValue / 655) ) ; 
            __context__.SourceCodeLine = 180;
            LASTCOMMAND = (ushort) ( 18 ) ; 
            __context__.SourceCodeLine = 181;
            MakeString ( SBUILD , "\u00AA\u0012{0}\u0001{1}", SID , Functions.Chr (  (int) ( IVOLUME ) ) ) ; 
            __context__.SourceCodeLine = 182;
            LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
            
            }
            
        private void PROCESSRXD (  SplusExecutionContext __context__, CrestronString SFB ) 
            { 
            ushort IRRR = 0;
            
            
            __context__.SourceCodeLine = 190;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)LASTCOMMAND);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 194;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 4 ) ) == 9))  ) ) 
                            { 
                            __context__.SourceCodeLine = 196;
                            IPOWER = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                            __context__.SourceCodeLine = 197;
                            IVOLUME = (ushort) ( Byte( SFB , (int)( 8 ) ) ) ; 
                            __context__.SourceCodeLine = 198;
                            LCDVOLUMELEVEL  .Value = (ushort) ( (IVOLUME * 655) ) ; 
                            __context__.SourceCodeLine = 199;
                            IMUTE = (ushort) ( Byte( SFB , (int)( 9 ) ) ) ; 
                            __context__.SourceCodeLine = 200;
                            LCD_MUTE_FB  .Value = (ushort) ( IMUTE ) ; 
                            __context__.SourceCodeLine = 201;
                            IINPUT = (ushort) ( Byte( SFB , (int)( 10 ) ) ) ; 
                            __context__.SourceCodeLine = 202;
                            LCD_IS_ON  .Value = (ushort) ( IPOWER ) ; 
                            __context__.SourceCodeLine = 203;
                            LCDCURRENTINPUT  .Value = (ushort) ( IINPUT ) ; 
                            __context__.SourceCodeLine = 204;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            __context__.SourceCodeLine = 205;
                            POWERSTATUSCOMP (  __context__  ) ; 
                            __context__.SourceCodeLine = 206;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 3 ) ) == IID))  ) ) 
                                { 
                                __context__.SourceCodeLine = 208;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 212;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 218;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 4 ) ) == 10))  ) ) 
                            { 
                            __context__.SourceCodeLine = 225;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 230;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 11))  ) ) 
                            { 
                            __context__.SourceCodeLine = 233;
                            STRASH  .UpdateValue ( Functions.Remove ( "\u000B" , SFB , 4)  ) ; 
                            __context__.SourceCodeLine = 234;
                            ICOUNT = (ushort) ( Functions.Length( SFB ) ) ; 
                            __context__.SourceCodeLine = 235;
                            ICOUNT = (ushort) ( (ICOUNT - 4) ) ; 
                            __context__.SourceCodeLine = 236;
                            SSERIALN  .UpdateValue ( Functions.Mid ( SFB ,  (int) ( 1 ) ,  (int) ( ICOUNT ) )  ) ; 
                            __context__.SourceCodeLine = 237;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            __context__.SourceCodeLine = 238;
                            LCD_SERIAL  .UpdateValue ( SSERIALN  ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 243;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 14))  ) ) 
                            { 
                            __context__.SourceCodeLine = 245;
                            STRASH  .UpdateValue ( Functions.Remove ( "\u000E" , SFB , 4)  ) ; 
                            __context__.SourceCodeLine = 246;
                            ICOUNT = (ushort) ( Functions.Length( SFB ) ) ; 
                            __context__.SourceCodeLine = 247;
                            ICOUNT = (ushort) ( (ICOUNT - 1) ) ; 
                            __context__.SourceCodeLine = 248;
                            SSOFTWARE  .UpdateValue ( Functions.Mid ( SFB ,  (int) ( 1 ) ,  (int) ( ICOUNT ) )  ) ; 
                            __context__.SourceCodeLine = 249;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            __context__.SourceCodeLine = 250;
                            LCD_SOFTWARE  .UpdateValue ( SSOFTWARE  ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 255;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 13))  ) ) 
                            { 
                            __context__.SourceCodeLine = 257;
                            ITEMPERATURE = (ushort) ( Byte( SFB , (int)( 11 ) ) ) ; 
                            __context__.SourceCodeLine = 258;
                            LCDTEMPERATURE  .Value = (ushort) ( ITEMPERATURE ) ; 
                            __context__.SourceCodeLine = 259;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            __context__.SourceCodeLine = 260;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 3 ) ) == IID))  ) ) 
                                { 
                                __context__.SourceCodeLine = 262;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 266;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 176) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 272;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 176))  ) ) 
                            { 
                            __context__.SourceCodeLine = 275;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 17) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 280;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 5 ) ) == 65))  ) ) 
                            { 
                            __context__.SourceCodeLine = 282;
                            IPOWER = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                            __context__.SourceCodeLine = 283;
                            LCD_IS_ON  .Value = (ushort) ( IPOWER ) ; 
                            __context__.SourceCodeLine = 284;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            __context__.SourceCodeLine = 285;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 3 ) ) == IID))  ) ) 
                                { 
                                __context__.SourceCodeLine = 287;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 1 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 291;
                                LCD_IS_RESPONDING  .Value = (ushort) ( 0 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 20) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 297;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 20))  ) ) 
                            { 
                            __context__.SourceCodeLine = 299;
                            IINPUT = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                            __context__.SourceCodeLine = 300;
                            LCDCURRENTINPUT  .Value = (ushort) ( IINPUT ) ; 
                            __context__.SourceCodeLine = 302;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 131) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 307;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 131))  ) ) 
                            { 
                            __context__.SourceCodeLine = 310;
                            IRRR = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                            __context__.SourceCodeLine = 311;
                            IRRR = (ushort) ( (IRRR * 255) ) ; 
                            __context__.SourceCodeLine = 312;
                            IRRR = (ushort) ( (IRRR + Byte( SFB , (int)( 8 ) )) ) ; 
                            __context__.SourceCodeLine = 313;
                            IRUNTIME = (ushort) ( (IRRR / 6) ) ; 
                            __context__.SourceCodeLine = 314;
                            LCDRUNTIME  .Value = (ushort) ( IRUNTIME ) ; 
                            __context__.SourceCodeLine = 315;
                            LASTCOMMAND = (ushort) ( 255 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 18) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 321;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 18))  ) ) 
                            { 
                            __context__.SourceCodeLine = 323;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 5 ) ) == 65))  ) ) 
                                { 
                                __context__.SourceCodeLine = 325;
                                IVOLUME = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                                __context__.SourceCodeLine = 326;
                                LCDVOLUMELEVEL  .Value = (ushort) ( (IVOLUME * 655) ) ; 
                                __context__.SourceCodeLine = 327;
                                LASTCOMMAND = (ushort) ( 255 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 19) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 334;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 6 ) ) == 19))  ) ) 
                            { 
                            __context__.SourceCodeLine = 336;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( SFB , (int)( 5 ) ) == 65))  ) ) 
                                { 
                                __context__.SourceCodeLine = 338;
                                IMUTE = (ushort) ( Byte( SFB , (int)( 7 ) ) ) ; 
                                __context__.SourceCodeLine = 339;
                                LCD_MUTE_FB  .Value = (ushort) ( IMUTE ) ; 
                                __context__.SourceCodeLine = 340;
                                LASTCOMMAND = (ushort) ( 255 ) ; 
                                } 
                            
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 346;
                        LASTCOMMAND = (ushort) ( 255 ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            
            }
            
        object REQUESTSERIAL_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 362;
                MakeString ( SBUILD , "\u00AA\u000B{0}\u0000", SID ) ; 
                __context__.SourceCodeLine = 363;
                LASTCOMMAND = (ushort) ( 11 ) ; 
                __context__.SourceCodeLine = 364;
                LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object REQUESTSOFTWAREVER_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 373;
            MakeString ( SBUILD , "\u00AA\u000E{0}\u0000", SID ) ; 
            __context__.SourceCodeLine = 374;
            LASTCOMMAND = (ushort) ( 14 ) ; 
            __context__.SourceCodeLine = 375;
            LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object REQUESTMAINTENANCEINFO_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 384;
        LASTCOMMAND = (ushort) ( 13 ) ; 
        __context__.SourceCodeLine = 385;
        MakeString ( SBUILD , "\u00AA\u000D{0}\u0000", SID ) ; 
        __context__.SourceCodeLine = 386;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_STATUS_REQ_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 391;
        LASTCOMMAND = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 392;
        MakeString ( SBUILD , "\u00AA\u0000{0}\u0000", SID ) ; 
        __context__.SourceCodeLine = 393;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_PANEL_RUNTIME_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 399;
        LASTCOMMAND = (ushort) ( 131 ) ; 
        __context__.SourceCodeLine = 400;
        MakeString ( SBUILD , "\u00AA\u0083{0}\u0000", SID ) ; 
        __context__.SourceCodeLine = 401;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_ID_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 408;
        SID  .UpdateValue ( Functions.Chr (  (int) ( LCD_ID  .UshortValue ) )  ) ; 
        __context__.SourceCodeLine = 409;
        IID = (ushort) ( LCD_ID  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_MENU_OnPush_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 414;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 415;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u001A", SID ) ; 
        __context__.SourceCodeLine = 416;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_EXIT_OnPush_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 421;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 422;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u002D", SID ) ; 
        __context__.SourceCodeLine = 423;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_RETURN_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 428;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 429;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0058", SID ) ; 
        __context__.SourceCodeLine = 430;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_ENTER_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 435;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 436;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0068", SID ) ; 
        __context__.SourceCodeLine = 437;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_UP_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 442;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 443;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0060", SID ) ; 
        __context__.SourceCodeLine = 444;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_DOWN_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 449;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 450;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0061", SID ) ; 
        __context__.SourceCodeLine = 451;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_LEFT_OnPush_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 456;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 457;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0065", SID ) ; 
        __context__.SourceCodeLine = 458;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_RIGHT_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 463;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 464;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u0062", SID ) ; 
        __context__.SourceCodeLine = 465;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_TOOLS_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 470;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 471;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001\u004B", SID ) ; 
        __context__.SourceCodeLine = 472;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_POWER_ON_OnPush_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 477;
        LASTCOMMAND = (ushort) ( 17 ) ; 
        __context__.SourceCodeLine = 478;
        MakeString ( SBUILD , "\u00AA\u0011{0}\u0001\u0001", SID ) ; 
        __context__.SourceCodeLine = 479;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        __context__.SourceCodeLine = 480;
        IPOWERREQ = (ushort) ( 1 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_POWER_OFF_OnPush_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 485;
        LASTCOMMAND = (ushort) ( 17 ) ; 
        __context__.SourceCodeLine = 486;
        MakeString ( SBUILD , "\u00AA\u0011{0}\u0001\u0000", SID ) ; 
        __context__.SourceCodeLine = 487;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        __context__.SourceCodeLine = 488;
        IPOWERREQ = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_HDMI1_OnPush_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 494;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 495;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0021", SID ) ; 
        __context__.SourceCodeLine = 496;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_HDMI2_OnPush_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 501;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 502;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0023", SID ) ; 
        __context__.SourceCodeLine = 503;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_HDMI3_OnPush_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 508;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 509;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0031", SID ) ; 
        __context__.SourceCodeLine = 510;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_DVI_OnPush_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 515;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 516;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0018", SID ) ; 
        __context__.SourceCodeLine = 517;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_DPORT_OnPush_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 522;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 523;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0025", SID ) ; 
        __context__.SourceCodeLine = 524;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_VGA_OnPush_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 529;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 530;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0014", SID ) ; 
        __context__.SourceCodeLine = 531;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_DTV_OnPush_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 536;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 537;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0040", SID ) ; 
        __context__.SourceCodeLine = 538;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_PIM_OnPush_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 543;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 544;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0050", SID ) ; 
        __context__.SourceCodeLine = 545;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_HDBASET_OnPush_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 550;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 551;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0055", SID ) ; 
        __context__.SourceCodeLine = 552;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_MAGICINFO_OnPush_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 557;
        LASTCOMMAND = (ushort) ( 20 ) ; 
        __context__.SourceCodeLine = 558;
        MakeString ( SBUILD , "\u00AA\u0014{0}\u0001\u0020", SID ) ; 
        __context__.SourceCodeLine = 559;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_UP_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 564;
        LASTCOMMAND = (ushort) ( 18 ) ; 
        __context__.SourceCodeLine = 565;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME < 100 ))  ) ) 
            {
            __context__.SourceCodeLine = 566;
            IVOLUME = (ushort) ( (IVOLUME + 1) ) ; 
            }
        
        __context__.SourceCodeLine = 568;
        MakeString ( SBUILD , "\u00AA\u0012{0}\u0001{1}", SID , Functions.Chr (  (int) ( IVOLUME ) ) ) ; 
        __context__.SourceCodeLine = 569;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_DOWN_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 574;
        LASTCOMMAND = (ushort) ( 18 ) ; 
        __context__.SourceCodeLine = 575;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IVOLUME > 0 ))  ) ) 
            {
            __context__.SourceCodeLine = 576;
            IVOLUME = (ushort) ( (IVOLUME - 1) ) ; 
            }
        
        __context__.SourceCodeLine = 578;
        MakeString ( SBUILD , "\u00AA\u0012{0}\u0001{1}", SID , Functions.Chr (  (int) ( IVOLUME ) ) ) ; 
        __context__.SourceCodeLine = 579;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 584;
        LASTCOMMAND = (ushort) ( 19 ) ; 
        __context__.SourceCodeLine = 585;
        IMUTE = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 586;
        MakeString ( SBUILD , "\u00AA\u0013{0}\u0001{1}", SID , Functions.Chr (  (int) ( IMUTE ) ) ) ; 
        __context__.SourceCodeLine = 587;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object UNMUTE_OnPush_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 592;
        LASTCOMMAND = (ushort) ( 19 ) ; 
        __context__.SourceCodeLine = 593;
        IMUTE = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 594;
        MakeString ( SBUILD , "\u00AA\u0013{0}\u0001{1}", SID , Functions.Chr (  (int) ( IMUTE ) ) ) ; 
        __context__.SourceCodeLine = 595;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_TOGGLE_OnPush_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 600;
        LASTCOMMAND = (ushort) ( 19 ) ; 
        __context__.SourceCodeLine = 601;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IMUTE == 1))  ) ) 
            {
            __context__.SourceCodeLine = 602;
            IMUTE = (ushort) ( 0 ) ; 
            }
        
        else 
            {
            __context__.SourceCodeLine = 604;
            IMUTE = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 606;
        MakeString ( SBUILD , "\u00AA\u0013{0}\u0001{1}", SID , Functions.Chr (  (int) ( IMUTE ) ) ) ; 
        __context__.SourceCodeLine = 607;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOL_RESET_OnPush_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 612;
        RESETVOLUME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNEL_UP_OnPush_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 617;
        LASTCOMMAND = (ushort) ( 97 ) ; 
        __context__.SourceCodeLine = 618;
        MakeString ( SBUILD , "\u00AA\u0061{0}\u0001\u0000", SID ) ; 
        __context__.SourceCodeLine = 619;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CHANNEL_DOWN_OnPush_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 624;
        LASTCOMMAND = (ushort) ( 97 ) ; 
        __context__.SourceCodeLine = 625;
        MakeString ( SBUILD , "\u00AA\u0061{0}\u0001\u0001", SID ) ; 
        __context__.SourceCodeLine = 626;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_DEFAULT_OnChange_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 631;
        RESETVOLUME (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_SLIDER_DRIVE_OnChange_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 636;
        LASTCOMMAND = (ushort) ( 18 ) ; 
        __context__.SourceCodeLine = 637;
        IVOLUME = (ushort) ( (VOLUME_SLIDER_DRIVE  .UshortValue / 655) ) ; 
        __context__.SourceCodeLine = 638;
        MakeString ( SBUILD , "\u00AA\u0012{0}\u0001{1}", SID , Functions.Chr (  (int) ( IVOLUME ) ) ) ; 
        __context__.SourceCodeLine = 639;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LCD_RXD__DOLLAR___OnChange_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 644;
        STEMP  .UpdateValue ( LCD_RXD__DOLLAR__  ) ; 
        __context__.SourceCodeLine = 645;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (IBUSY == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 647;
            if ( Functions.TestForTrue  ( ( Functions.Find( "\u00AA" , STEMP , 1 ))  ) ) 
                { 
                __context__.SourceCodeLine = 649;
                Functions.Delay (  (int) ( 20 ) ) ; 
                __context__.SourceCodeLine = 650;
                IBUSY = (ushort) ( 1 ) ; 
                __context__.SourceCodeLine = 651;
                PROCESSRXD (  __context__ , STEMP) ; 
                __context__.SourceCodeLine = 652;
                Functions.ProcessLogic ( ) ; 
                __context__.SourceCodeLine = 653;
                Functions.ClearBuffer ( LCD_RXD__DOLLAR__ ) ; 
                __context__.SourceCodeLine = 654;
                IBUSY = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TV_CHANNEL_OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 661;
        LASTCOMMAND = (ushort) ( 23 ) ; 
        __context__.SourceCodeLine = 662;
        ICH = (ushort) ( TV_CHANNEL  .UshortValue ) ; 
        __context__.SourceCodeLine = 663;
        MakeString ( SBUILD , "\u00AA\u0017{0}\u0008\u0000\u0001\u0000{1}\u0000\u0000\u0000\u0000", SID , Functions.Chr (  (int) ( ICH ) ) ) ; 
        __context__.SourceCodeLine = 664;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEY_NUMBER_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort IDIGI = 0;
        ushort IKEYV = 0;
        
        
        __context__.SourceCodeLine = 672;
        IDIGI = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
        __context__.SourceCodeLine = 674;
        LASTCOMMAND = (ushort) ( 176 ) ; 
        __context__.SourceCodeLine = 676;
        
            {
            int __SPLS_TMPVAR__SWTCH_3__ = ((int)IDIGI);
            
                { 
                if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 0) ) ) ) 
                    {
                    __context__.SourceCodeLine = 678;
                    IKEYV = (ushort) ( 17 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                    {
                    __context__.SourceCodeLine = 679;
                    IKEYV = (ushort) ( 4 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                    {
                    __context__.SourceCodeLine = 680;
                    IKEYV = (ushort) ( 5 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                    {
                    __context__.SourceCodeLine = 681;
                    IKEYV = (ushort) ( 6 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                    {
                    __context__.SourceCodeLine = 682;
                    IKEYV = (ushort) ( 8 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                    {
                    __context__.SourceCodeLine = 683;
                    IKEYV = (ushort) ( 9 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                    {
                    __context__.SourceCodeLine = 684;
                    IKEYV = (ushort) ( 10 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                    {
                    __context__.SourceCodeLine = 685;
                    IKEYV = (ushort) ( 12 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 8) ) ) ) 
                    {
                    __context__.SourceCodeLine = 686;
                    IKEYV = (ushort) ( 13 ) ; 
                    }
                
                else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 9) ) ) ) 
                    {
                    __context__.SourceCodeLine = 687;
                    IKEYV = (ushort) ( 14 ) ; 
                    }
                
                } 
                
            }
            
        
        __context__.SourceCodeLine = 689;
        MakeString ( SBUILD , "\u00AA\u00B0{0}\u0001{1}", SID , Functions.Chr (  (int) ( IKEYV ) ) ) ; 
        __context__.SourceCodeLine = 690;
        LCD_TXD__DOLLAR__  .UpdateValue ( ADDCSTOSTRING (  __context__ , SBUILD)  ) ; 
        
        
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
        
        __context__.SourceCodeLine = 704;
        IBUSY = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 705;
        SID  .UpdateValue ( Functions.Chr (  (int) ( 254 ) )  ) ; 
        __context__.SourceCodeLine = 706;
        IID = (ushort) ( 254 ) ; 
        __context__.SourceCodeLine = 707;
        WaitForInitializationComplete ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    SSERIALN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    SSOFTWARE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    STEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    STRASH  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    SID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    SID2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    SBUILD  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    
    REQUESTSERIAL = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSERIAL__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSERIAL__DigitalInput__, REQUESTSERIAL );
    
    REQUESTSOFTWAREVER = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTSOFTWAREVER__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTSOFTWAREVER__DigitalInput__, REQUESTSOFTWAREVER );
    
    REQUESTMAINTENANCEINFO = new Crestron.Logos.SplusObjects.DigitalInput( REQUESTMAINTENANCEINFO__DigitalInput__, this );
    m_DigitalInputList.Add( REQUESTMAINTENANCEINFO__DigitalInput__, REQUESTMAINTENANCEINFO );
    
    LCD_STATUS_REQ = new Crestron.Logos.SplusObjects.DigitalInput( LCD_STATUS_REQ__DigitalInput__, this );
    m_DigitalInputList.Add( LCD_STATUS_REQ__DigitalInput__, LCD_STATUS_REQ );
    
    LCD_PANEL_RUNTIME = new Crestron.Logos.SplusObjects.DigitalInput( LCD_PANEL_RUNTIME__DigitalInput__, this );
    m_DigitalInputList.Add( LCD_PANEL_RUNTIME__DigitalInput__, LCD_PANEL_RUNTIME );
    
    KEY_MENU = new Crestron.Logos.SplusObjects.DigitalInput( KEY_MENU__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_MENU__DigitalInput__, KEY_MENU );
    
    KEY_RETURN = new Crestron.Logos.SplusObjects.DigitalInput( KEY_RETURN__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_RETURN__DigitalInput__, KEY_RETURN );
    
    KEY_ENTER = new Crestron.Logos.SplusObjects.DigitalInput( KEY_ENTER__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_ENTER__DigitalInput__, KEY_ENTER );
    
    KEY_UP = new Crestron.Logos.SplusObjects.DigitalInput( KEY_UP__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_UP__DigitalInput__, KEY_UP );
    
    KEY_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( KEY_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_DOWN__DigitalInput__, KEY_DOWN );
    
    KEY_LEFT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_LEFT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_LEFT__DigitalInput__, KEY_LEFT );
    
    KEY_RIGHT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_RIGHT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_RIGHT__DigitalInput__, KEY_RIGHT );
    
    KEY_TOOLS = new Crestron.Logos.SplusObjects.DigitalInput( KEY_TOOLS__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_TOOLS__DigitalInput__, KEY_TOOLS );
    
    KEY_EXIT = new Crestron.Logos.SplusObjects.DigitalInput( KEY_EXIT__DigitalInput__, this );
    m_DigitalInputList.Add( KEY_EXIT__DigitalInput__, KEY_EXIT );
    
    LCD_POWER_ON = new Crestron.Logos.SplusObjects.DigitalInput( LCD_POWER_ON__DigitalInput__, this );
    m_DigitalInputList.Add( LCD_POWER_ON__DigitalInput__, LCD_POWER_ON );
    
    LCD_POWER_OFF = new Crestron.Logos.SplusObjects.DigitalInput( LCD_POWER_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( LCD_POWER_OFF__DigitalInput__, LCD_POWER_OFF );
    
    INPUT_HDMI1 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_HDMI1__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_HDMI1__DigitalInput__, INPUT_HDMI1 );
    
    INPUT_HDMI2 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_HDMI2__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_HDMI2__DigitalInput__, INPUT_HDMI2 );
    
    INPUT_HDMI3 = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_HDMI3__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_HDMI3__DigitalInput__, INPUT_HDMI3 );
    
    INPUT_DVI = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_DVI__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_DVI__DigitalInput__, INPUT_DVI );
    
    INPUT_DPORT = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_DPORT__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_DPORT__DigitalInput__, INPUT_DPORT );
    
    INPUT_VGA = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_VGA__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_VGA__DigitalInput__, INPUT_VGA );
    
    INPUT_DTV = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_DTV__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_DTV__DigitalInput__, INPUT_DTV );
    
    INPUT_PIM = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_PIM__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_PIM__DigitalInput__, INPUT_PIM );
    
    INPUT_HDBASET = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_HDBASET__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_HDBASET__DigitalInput__, INPUT_HDBASET );
    
    INPUT_MAGICINFO = new Crestron.Logos.SplusObjects.DigitalInput( INPUT_MAGICINFO__DigitalInput__, this );
    m_DigitalInputList.Add( INPUT_MAGICINFO__DigitalInput__, INPUT_MAGICINFO );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_UP__DigitalInput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( VOLUME_DOWN__DigitalInput__, VOLUME_DOWN );
    
    MUTE = new Crestron.Logos.SplusObjects.DigitalInput( MUTE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE__DigitalInput__, MUTE );
    
    UNMUTE = new Crestron.Logos.SplusObjects.DigitalInput( UNMUTE__DigitalInput__, this );
    m_DigitalInputList.Add( UNMUTE__DigitalInput__, UNMUTE );
    
    MUTE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_TOGGLE__DigitalInput__, MUTE_TOGGLE );
    
    VOL_RESET = new Crestron.Logos.SplusObjects.DigitalInput( VOL_RESET__DigitalInput__, this );
    m_DigitalInputList.Add( VOL_RESET__DigitalInput__, VOL_RESET );
    
    CHANNEL_UP = new Crestron.Logos.SplusObjects.DigitalInput( CHANNEL_UP__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNEL_UP__DigitalInput__, CHANNEL_UP );
    
    CHANNEL_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( CHANNEL_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( CHANNEL_DOWN__DigitalInput__, CHANNEL_DOWN );
    
    KEY_NUMBER = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        KEY_NUMBER[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KEY_NUMBER__DigitalInput__ + i, KEY_NUMBER__DigitalInput__, this );
        m_DigitalInputList.Add( KEY_NUMBER__DigitalInput__ + i, KEY_NUMBER[i+1] );
    }
    
    LCD_IS_ON = new Crestron.Logos.SplusObjects.DigitalOutput( LCD_IS_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( LCD_IS_ON__DigitalOutput__, LCD_IS_ON );
    
    LCD_IS_RESPONDING = new Crestron.Logos.SplusObjects.DigitalOutput( LCD_IS_RESPONDING__DigitalOutput__, this );
    m_DigitalOutputList.Add( LCD_IS_RESPONDING__DigitalOutput__, LCD_IS_RESPONDING );
    
    LCD_MUTE_FB = new Crestron.Logos.SplusObjects.DigitalOutput( LCD_MUTE_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( LCD_MUTE_FB__DigitalOutput__, LCD_MUTE_FB );
    
    LCD_ID = new Crestron.Logos.SplusObjects.AnalogInput( LCD_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( LCD_ID__AnalogSerialInput__, LCD_ID );
    
    VOLUME_DEFAULT = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_DEFAULT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_DEFAULT__AnalogSerialInput__, VOLUME_DEFAULT );
    
    VOLUME_SLIDER_DRIVE = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_SLIDER_DRIVE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_SLIDER_DRIVE__AnalogSerialInput__, VOLUME_SLIDER_DRIVE );
    
    TV_CHANNEL = new Crestron.Logos.SplusObjects.AnalogInput( TV_CHANNEL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TV_CHANNEL__AnalogSerialInput__, TV_CHANNEL );
    
    LCDTEMPERATURE = new Crestron.Logos.SplusObjects.AnalogOutput( LCDTEMPERATURE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LCDTEMPERATURE__AnalogSerialOutput__, LCDTEMPERATURE );
    
    LCDCURRENTINPUT = new Crestron.Logos.SplusObjects.AnalogOutput( LCDCURRENTINPUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LCDCURRENTINPUT__AnalogSerialOutput__, LCDCURRENTINPUT );
    
    LCDRUNTIME = new Crestron.Logos.SplusObjects.AnalogOutput( LCDRUNTIME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LCDRUNTIME__AnalogSerialOutput__, LCDRUNTIME );
    
    LCDVOLUMELEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( LCDVOLUMELEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LCDVOLUMELEVEL__AnalogSerialOutput__, LCDVOLUMELEVEL );
    
    LCD_TXD__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( LCD_TXD__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( LCD_TXD__DOLLAR____AnalogSerialOutput__, LCD_TXD__DOLLAR__ );
    
    LCD_SERIAL = new Crestron.Logos.SplusObjects.StringOutput( LCD_SERIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( LCD_SERIAL__AnalogSerialOutput__, LCD_SERIAL );
    
    LCD_SOFTWARE = new Crestron.Logos.SplusObjects.StringOutput( LCD_SOFTWARE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( LCD_SOFTWARE__AnalogSerialOutput__, LCD_SOFTWARE );
    
    LCD_RXD__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( LCD_RXD__DOLLAR____AnalogSerialInput__, 255, this );
    m_StringInputList.Add( LCD_RXD__DOLLAR____AnalogSerialInput__, LCD_RXD__DOLLAR__ );
    
    
    REQUESTSERIAL.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSERIAL_OnPush_0, false ) );
    REQUESTSOFTWAREVER.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTSOFTWAREVER_OnPush_1, false ) );
    REQUESTMAINTENANCEINFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( REQUESTMAINTENANCEINFO_OnPush_2, false ) );
    LCD_STATUS_REQ.OnDigitalPush.Add( new InputChangeHandlerWrapper( LCD_STATUS_REQ_OnPush_3, false ) );
    LCD_PANEL_RUNTIME.OnDigitalPush.Add( new InputChangeHandlerWrapper( LCD_PANEL_RUNTIME_OnPush_4, false ) );
    LCD_ID.OnAnalogChange.Add( new InputChangeHandlerWrapper( LCD_ID_OnChange_5, false ) );
    KEY_MENU.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_MENU_OnPush_6, false ) );
    KEY_EXIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_EXIT_OnPush_7, false ) );
    KEY_RETURN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_RETURN_OnPush_8, false ) );
    KEY_ENTER.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_ENTER_OnPush_9, false ) );
    KEY_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_UP_OnPush_10, false ) );
    KEY_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_DOWN_OnPush_11, false ) );
    KEY_LEFT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_LEFT_OnPush_12, false ) );
    KEY_RIGHT.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_RIGHT_OnPush_13, false ) );
    KEY_TOOLS.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_TOOLS_OnPush_14, false ) );
    LCD_POWER_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( LCD_POWER_ON_OnPush_15, false ) );
    LCD_POWER_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( LCD_POWER_OFF_OnPush_16, false ) );
    INPUT_HDMI1.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_HDMI1_OnPush_17, false ) );
    INPUT_HDMI2.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_HDMI2_OnPush_18, false ) );
    INPUT_HDMI3.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_HDMI3_OnPush_19, false ) );
    INPUT_DVI.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_DVI_OnPush_20, false ) );
    INPUT_DPORT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_DPORT_OnPush_21, false ) );
    INPUT_VGA.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_VGA_OnPush_22, false ) );
    INPUT_DTV.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_DTV_OnPush_23, false ) );
    INPUT_PIM.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_PIM_OnPush_24, false ) );
    INPUT_HDBASET.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_HDBASET_OnPush_25, false ) );
    INPUT_MAGICINFO.OnDigitalPush.Add( new InputChangeHandlerWrapper( INPUT_MAGICINFO_OnPush_26, false ) );
    VOLUME_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_UP_OnPush_27, false ) );
    VOLUME_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOLUME_DOWN_OnPush_28, false ) );
    MUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_OnPush_29, false ) );
    UNMUTE.OnDigitalPush.Add( new InputChangeHandlerWrapper( UNMUTE_OnPush_30, false ) );
    MUTE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTE_TOGGLE_OnPush_31, false ) );
    VOL_RESET.OnDigitalPush.Add( new InputChangeHandlerWrapper( VOL_RESET_OnPush_32, false ) );
    CHANNEL_UP.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNEL_UP_OnPush_33, false ) );
    CHANNEL_DOWN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CHANNEL_DOWN_OnPush_34, false ) );
    VOLUME_DEFAULT.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_DEFAULT_OnChange_35, false ) );
    VOLUME_SLIDER_DRIVE.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_SLIDER_DRIVE_OnChange_36, false ) );
    LCD_RXD__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( LCD_RXD__DOLLAR___OnChange_37, false ) );
    TV_CHANNEL.OnAnalogChange.Add( new InputChangeHandlerWrapper( TV_CHANNEL_OnChange_38, false ) );
    for( uint i = 0; i < 10; i++ )
        KEY_NUMBER[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KEY_NUMBER_OnPush_39, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_SAMSUNG_EXTRA_ID_V1_3 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint REQUESTSERIAL__DigitalInput__ = 0;
const uint REQUESTSOFTWAREVER__DigitalInput__ = 1;
const uint REQUESTMAINTENANCEINFO__DigitalInput__ = 2;
const uint LCD_STATUS_REQ__DigitalInput__ = 3;
const uint LCD_PANEL_RUNTIME__DigitalInput__ = 4;
const uint KEY_MENU__DigitalInput__ = 5;
const uint KEY_RETURN__DigitalInput__ = 6;
const uint KEY_ENTER__DigitalInput__ = 7;
const uint KEY_UP__DigitalInput__ = 8;
const uint KEY_DOWN__DigitalInput__ = 9;
const uint KEY_LEFT__DigitalInput__ = 10;
const uint KEY_RIGHT__DigitalInput__ = 11;
const uint KEY_TOOLS__DigitalInput__ = 12;
const uint KEY_EXIT__DigitalInput__ = 13;
const uint LCD_POWER_ON__DigitalInput__ = 14;
const uint LCD_POWER_OFF__DigitalInput__ = 15;
const uint INPUT_HDMI1__DigitalInput__ = 16;
const uint INPUT_HDMI2__DigitalInput__ = 17;
const uint INPUT_HDMI3__DigitalInput__ = 18;
const uint INPUT_DVI__DigitalInput__ = 19;
const uint INPUT_DPORT__DigitalInput__ = 20;
const uint INPUT_VGA__DigitalInput__ = 21;
const uint INPUT_DTV__DigitalInput__ = 22;
const uint INPUT_PIM__DigitalInput__ = 23;
const uint INPUT_HDBASET__DigitalInput__ = 24;
const uint INPUT_MAGICINFO__DigitalInput__ = 25;
const uint VOLUME_UP__DigitalInput__ = 26;
const uint VOLUME_DOWN__DigitalInput__ = 27;
const uint MUTE__DigitalInput__ = 28;
const uint UNMUTE__DigitalInput__ = 29;
const uint MUTE_TOGGLE__DigitalInput__ = 30;
const uint VOL_RESET__DigitalInput__ = 31;
const uint CHANNEL_UP__DigitalInput__ = 32;
const uint CHANNEL_DOWN__DigitalInput__ = 33;
const uint KEY_NUMBER__DigitalInput__ = 34;
const uint LCD_ID__AnalogSerialInput__ = 0;
const uint VOLUME_DEFAULT__AnalogSerialInput__ = 1;
const uint VOLUME_SLIDER_DRIVE__AnalogSerialInput__ = 2;
const uint TV_CHANNEL__AnalogSerialInput__ = 3;
const uint LCD_RXD__DOLLAR____AnalogSerialInput__ = 4;
const uint LCD_IS_ON__DigitalOutput__ = 0;
const uint LCD_IS_RESPONDING__DigitalOutput__ = 1;
const uint LCD_MUTE_FB__DigitalOutput__ = 2;
const uint LCDTEMPERATURE__AnalogSerialOutput__ = 0;
const uint LCDCURRENTINPUT__AnalogSerialOutput__ = 1;
const uint LCDRUNTIME__AnalogSerialOutput__ = 2;
const uint LCDVOLUMELEVEL__AnalogSerialOutput__ = 3;
const uint LCD_TXD__DOLLAR____AnalogSerialOutput__ = 4;
const uint LCD_SERIAL__AnalogSerialOutput__ = 5;
const uint LCD_SOFTWARE__AnalogSerialOutput__ = 6;

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
