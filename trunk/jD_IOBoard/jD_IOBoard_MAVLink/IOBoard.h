#define EN  1     // Enable value
#define DI  0     // Disable value


// Flight mode defines
#define STAB 0
#define ACRO 1
#define ALTH 2
#define AUTO 3
#define LOIT 4
#define GUID 5
#define RETL 6
#define CIRC 7
#define POSI 8
#define LAND 9
#define OFLO 10
#define MANU 11
#define FBWA 12
#define FBWB 13

// MAVLink HeartBeat bits
#define MOTORS_ARMED 128



///////////////////////////
// Global variables
static int counter = 0;     // General counter

static byte ioOut = 0;      // Blinker output position
static byte ioStat = LOW;   // Blinker last status
static byte ioCounter = 0;  // Blinker count

static int Out[] = {8,9,10,4,3,2};   // Output I/O pin array
static int IOState[] = {0,0,0,0,0,0};

static byte patt_pos;
static byte patt;

static int pwm1;  // value holders for pwm outputs (if any)
static int pwm2;
static int pwm3;

static boolean pwm1dir;
static boolean pwm2dir;
static boolean pwm3dir;

static float    iob_vbat_A = 0;                 // Battery A voltage in milivolt
//static float    iob_curr_A = 0;                 // Battery A current
static uint16_t iob_battery_remaining_A = 0;    // 0 to 100 <=> 0 to 1000
static uint8_t  iob_battery_pic_A = 0xb4;       // picture to show battery remaining
//static float    iob_vbat_B = 0;               // voltage in milivolt
//static float    iob_curr_B = 0;                 // Battery B current
//static uint16_t iob_battery_remaining_B = 0;  // 0 to 100 <=> 0 to 1000
//static uint8_t  iob_battery_pic_B = 0xb4;     // picture to show battery remaining

static uint16_t iob_mode = 0;                   // Navigation mode from RC AC2 = CH5, APM = CH8
static uint8_t  iob_nav_mode = 0;               // Navigation mode from RC AC2 = CH5, APM = CH8

static float    iob_lat = 0;                    // latidude
static float    iob_lon = 0;                    // longitude
static uint8_t  iob_satellites_visible = 0;     // number of satelites
static uint8_t  iob_fix_type = 0;               // GPS lock 0-1=no fix, 2=2D, 3=3D

static uint8_t  iob_got_home = 0;               // tels if got home position or not
static float    iob_home_lat = 0;               // home latidude
static float    iob_home_lon = 0;               // home longitude
static float    iob_home_alt = 0; 
static long     iob_home_distance = 0;          // distance from home
static uint8_t  iob_home_direction;             // Arrow direction pointing to home (1-16 to CW loop)

static int8_t      iob_pitch = 0;                  // pitch form DCM
static int8_t      iob_roll = 0;                   // roll form DCM
static int8_t      iob_yaw = 0;                    // relative heading form DCM
static float    iob_heading = 0;                // ground course heading from GPS
static float    iob_alt = 0;                    // altitude
static float    iob_groundspeed = 0;            // ground speed
static uint16_t iob_throttle = 0;               // throtle

//MAVLink session control
static boolean  mavbeat = 0;
static float    lastMAVBeat = 0;
static boolean  waitingMAVBeats = 1;
static uint8_t  apm_mav_type;
static uint8_t  apm_mav_system; 
static uint8_t  apm_mav_component;
static boolean  enable_mav_request = 0;


int tempvar;      // Temporary variable used on many places around the OSD

byte flMode;  // Our current flight mode as defined

