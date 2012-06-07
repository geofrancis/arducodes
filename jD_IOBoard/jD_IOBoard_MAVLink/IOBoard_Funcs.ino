/*

  IOBoard general funcion calls




*/

// Roll all outputs one time one by one and have delay XX ms between status changes
void SlowRoll(int FlashDly) {
 for(int pos = 0; pos <= 5; pos ++ ) {
   digitalWrite(Out[pos], EN);
   delay(FlashDly);
   digitalWrite(Out[pos], DI);
   delay(FlashDly);   
 }
}

// Switch all outputs ON
void AllOn() {
  if(debug) Serial.println("AllOn");
   for(int looper = 0; looper <= 5; looper++) {
    digitalWrite(Out[looper],EN);
  }  
}


// Switch all outputs OFF
void AllOff() {
  if(debug) Serial.println("AllOff");
   for(int looper = 0; looper <= 5; looper++) {
    digitalWrite(Out[looper],DI);
  }  
}


#ifdef HEARTBEAT
void HeartBeat() {
   curMillis = millis();
  if(curMillis - preMillis > delMillis) {
    // save the last time you blinked the LED 
    preMillis = curMillis;   

    // if the LED is off turn it on and vice-versa:
      if (ledState == LOW)
        ledState = HIGH;
      else
        ledState = LOW;

    // set the LED with the ledState of the variable:
    digitalWrite(ledPin, ledState); 
//    dbSerial.println("HB");
      messageCounter++;   

    }
}
#endif 
 
// Our generic flight modes for ArduCopter & ArduPlane
void CheckFlightMode() {
  if(apm_mav_type == 2) {  // ArduCopter
    if(iob_mode == 100) flMode = STAB; // Stabilize
    if(iob_mode == 101) flMode = ACRO; // Acrobatic
    if(iob_mode == 102) flMode = ALTH; // Alt Hold
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_WAYPOINT) flMode = AUTO; // Auto
    if(iob_mode == MAV_MODE_GUIDED && iob_nav_mode == MAV_NAV_WAYPOINT) flMode = GUID; // Guided
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_HOLD) flMode = LOIT; // Loiter
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_RETURNING) flMode = RETL; // Return to Launch
    if(iob_mode == 107) flMode = CIRC; // Circle
    if(iob_mode == 108) flMode = POSI; // Position
    if(iob_mode == 109) flMode = LAND; // Land
    if(iob_mode == 110) flMode = OFLO; // OF_Loiter 
  }
    else if(apm_mav_type == 1){ //ArduPlane
    if(iob_mode == MAV_MODE_TEST1 && iob_nav_mode == MAV_NAV_VECTOR) flMode = STAB; // Stabilize
    if(iob_mode == MAV_MODE_MANUAL && iob_nav_mode == MAV_NAV_VECTOR) flMode = MANU; // Manual
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_LOITER) flMode = LOIT; // Loiter
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_RETURNING) flMode = RETL; // Return to Launch
    if(iob_mode == MAV_MODE_TEST2 && iob_nav_mode == 1) flMode = FBWA; // FLY_BY_WIRE_A
    if(iob_mode == MAV_MODE_TEST2 && iob_nav_mode == 2) flMode = FBWB; // FLY_BY_WIRE_B
    if(iob_mode == MAV_MODE_GUIDED) flMode = GUID; // GUIDED
    if(iob_mode == MAV_MODE_AUTO && iob_nav_mode == MAV_NAV_WAYPOINT) flMode = AUTO; // AUTO
    if(iob_mode == MAV_MODE_TEST3) flMode = CIRC; // CIRCLE
  }
  
  patt = flMode + 1;
}

/*  OBSOLETE, moved to MACROS
// debug message printout 
void dbPRNL(char outstr[]) {
#ifdef DEBUGSERIAL
   dbSerial.println(outstr);
#endif  
}

// debug message printout
void dbPRN(char outstr[]) {
#ifdef DEBUGSERIAL
   dbSerial.print(outstr);
#endif  
}
*/


void RunPattern() {
      digitalWrite(REAR, flight_patt[patt][patt_pos]);
/*      DPL();
      DPN(patt, DEC);
      DPN("\t");
      DPN(patt_pos, DEC);
      DPN("\t");      
      DPL(flight_patt[patt][patt_pos],BIN); */
      patt_pos++;
      if(patt_pos == 16) patt_pos = 0;
}


// Reads current state of high power output and save them to parameter
void GetIO() {
  for(int pos = 0; pos <= 5; pos++) {
   IOState[pos] = digitalRead(Out[pos]);
  }
}

// Recalls save value for highpower IO states and outputs them back
void PutIO() {
  for(int pos = 0; pos <= 5; pos++) {
   digitalWrite(Out[pos], IOState[pos]);
  }
}



