#ifndef __S2_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2_H__
#define __S2_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_1_BT_DIG_INPUT 0
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_2_BT_DIG_INPUT 1
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_3_BT_DIG_INPUT 2
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_4_BT_DIG_INPUT 3
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_5_BT_DIG_INPUT 4
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_PRESET_6_BT_DIG_INPUT 5
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_UP_BT_DIG_INPUT 6
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_UP_BT_DIG_INPUT 7
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_UP_BT_DIG_INPUT 8
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_DN_BT_DIG_INPUT 9
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_DN_BT_DIG_INPUT 10
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_DN_BT_DIG_INPUT 11
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_1_TOGGLE_DIG_INPUT 12
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_2_TOGGLE_DIG_INPUT 13
#define __S2_CBusController_w_Settable_Levels_v2_LIGHTS_3_TOGGLE_DIG_INPUT 14


/*
* ANALOG_INPUT
*/

#define __S2_CBusController_w_Settable_Levels_v2_FROM_CBUS_STRING_INPUT 0
#define __S2_CBusController_w_Settable_Levels_v2_FROM_CBUS_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FROM_CBUS, __S2_CBusController_w_Settable_Levels_v2_FROM_CBUS_STRING_MAX_LEN );



/*
* DIGITAL_OUTPUT
*/
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_1_FB_DIG_OUTPUT 0
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_2_FB_DIG_OUTPUT 1
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_TOGGLE_3_FB_DIG_OUTPUT 2


/*
* ANALOG_OUTPUT
*/
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_1_ANALOG_OUTPUT 0
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_2_ANALOG_OUTPUT 1
#define __S2_CBusController_w_Settable_Levels_v2_LIGHT_LEVEL_3_ANALOG_OUTPUT 2

#define __S2_CBusController_w_Settable_Levels_v2_TO_CBUS_STRING_OUTPUT 3


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
#define __S2_CBusController_w_Settable_Levels_v2_PRESET1LEVELS_INTEGER_PARAMETER 18
#define __S2_CBusController_w_Settable_Levels_v2_PRESET1LEVELS_ARRAY_LENGTH 7
#define __S2_CBusController_w_Settable_Levels_v2_PRESET2LEVELS_INTEGER_PARAMETER 25
#define __S2_CBusController_w_Settable_Levels_v2_PRESET2LEVELS_ARRAY_LENGTH 7
#define __S2_CBusController_w_Settable_Levels_v2_PRESET3LEVELS_INTEGER_PARAMETER 32
#define __S2_CBusController_w_Settable_Levels_v2_PRESET3LEVELS_ARRAY_LENGTH 7
#define __S2_CBusController_w_Settable_Levels_v2_PRESET4LEVELS_INTEGER_PARAMETER 39
#define __S2_CBusController_w_Settable_Levels_v2_PRESET4LEVELS_ARRAY_LENGTH 7
#define __S2_CBusController_w_Settable_Levels_v2_PRESET5LEVELS_INTEGER_PARAMETER 46
#define __S2_CBusController_w_Settable_Levels_v2_PRESET5LEVELS_ARRAY_LENGTH 7
#define __S2_CBusController_w_Settable_Levels_v2_PRESET6LEVELS_INTEGER_PARAMETER 53
#define __S2_CBusController_w_Settable_Levels_v2_PRESET6LEVELS_ARRAY_LENGTH 7
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/
#define __S2_CBusController_w_Settable_Levels_v2_APPLICATION_STRING_PARAMETER 10
#define __S2_CBusController_w_Settable_Levels_v2_APPLICATION_PARAM_MAX_LEN 2
CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION, __S2_CBusController_w_Settable_Levels_v2_APPLICATION_PARAM_MAX_LEN );
#define __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_STRING_PARAMETER 11
#define __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_ELEMS 7
#define __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_CHARS 2
CREATE_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES, __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_ELEMS, __S2_CBusController_w_Settable_Levels_v2_CBUSADDRESSES_ARRAY_NUM_CHARS );


/*
* INTEGER
*/
CREATE_INTARRAY1D( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL, 7 );;

CREATE_INTARRAY2D( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL, 6, 7 );;

/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_CBusController_w_Settable_Levels_v2_STRHEADER_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER, __S2_CBusController_w_Settable_Levels_v2_STRHEADER_STRING_MAX_LEN );
#define __S2_CBusController_w_Settable_Levels_v2_STRMIDDLE_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE, __S2_CBusController_w_Settable_Levels_v2_STRMIDDLE_STRING_MAX_LEN );
#define __S2_CBusController_w_Settable_Levels_v2_STRFOOTER_STRING_MAX_LEN 10
CREATE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER, __S2_CBusController_w_Settable_Levels_v2_STRFOOTER_STRING_MAX_LEN );
#define __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_ELEMS 6
#define __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_CHARS 30
CREATE_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CPRESETSTRINGS, __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_ELEMS, __S2_CBusController_w_Settable_Levels_v2_CPRESETSTRINGS_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_CBusController_w_Settable_Levels_v2 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __PRESET1LEVELS );
   DECLARE_IO_ARRAY( __PRESET2LEVELS );
   DECLARE_IO_ARRAY( __PRESET3LEVELS );
   DECLARE_IO_ARRAY( __PRESET4LEVELS );
   DECLARE_IO_ARRAY( __PRESET5LEVELS );
   DECLARE_IO_ARRAY( __PRESET6LEVELS );
   unsigned short __NSENDSTRING;
   DECLARE_INTARRAY( S2_CBusController_w_Settable_Levels_v2, __NLIGHTLEVEL );
   DECLARE_INTARRAY( S2_CBusController_w_Settable_Levels_v2, __CPRESETLEVEL );
   DECLARE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRHEADER );
   DECLARE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRMIDDLE );
   DECLARE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __STRFOOTER );
   DECLARE_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CPRESETSTRINGS );
   DECLARE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __FROM_CBUS );
   DECLARE_STRING_STRUCT( S2_CBusController_w_Settable_Levels_v2, __APPLICATION );
   DECLARE_STRING_ARRAY( S2_CBusController_w_Settable_Levels_v2, __CBUSADDRESSES );
};

START_NVRAM_VAR_STRUCT( S2_CBusController_w_Settable_Levels_v2 )
{
};



#endif //__S2_CBUSCONTROLLER_W_SETTABLE_LEVELS_V2_H__

