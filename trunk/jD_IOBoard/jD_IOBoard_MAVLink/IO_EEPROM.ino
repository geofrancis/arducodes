/* 

   EEPROM Functions for jD-IOBoard.


*/

// EEPROM reader/writers
// Utilities for writing and reading from the EEPROM
byte readEEPROM(int address) {
  return EEPROM.read(address);
}

void writeEEPROM(int address, byte value) {
  EEPROM.write(address, value);
}

void writeEP2(int address, byte val1, byte val2) {
  EEPROM.write(address, val1);
  EEPROM.write(address + 1, val2); 
}



// Default patterns should look like these:
//  { 0,0,0,0,0,0,0,0 ,0,0,0,0,0,0,0,0  },    // 0   0x00 , 0x00
//  { 1,1,1,1,0,0,0,0 ,1,1,1,1,0,0,0,0  },    // 1   0xF0 , 0xF0    
//  { 1,1,1,1,1,0,0,0 ,0,0,0,0,0,1,0,0  },    // 2   0xF8 , 0x04
//  { 1,1,0,0,1,1,0,0 ,1,1,0,0,1,1,0,0  },    // 3   0xCC , 0xCC
//  { 1,0,0,0,1,0,0,0 ,1,0,0,0,1,0,0,0  },    // 4   0x88 , 0x88
//  { 1,0,1,0,1,0,1,0 ,1,0,1,0,0,0,0,0  },    // 5   0xAA , 0xA0
//  { 1,0,1,0,1,0,1,0 ,1,0,1,0,1,0,1,0  },    // 6   0xAA , 0xAA
//  { 1,0,1,0,0,0,0,0 ,1,0,1,0,0,0,0,0  },    // 7
//  { 1,1,0,0,0,0,0,0 ,1,1,0,0,0,0,0,0  },    // 8
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 9
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 10
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 11
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 12
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 13
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  },    // 14
//  { 1,0,0,0,0,0,0,0 ,1,0,0,0,0,0,0,0  }};   // 15



// Write our latest FACTORY settings to EEPROM
void writeFactorySettings() {
 // Writing all default parameters to EEPROM

 // Default patterns 1-16
 writeEP2(pat01_ADDR, 0b11000000, 0b00000000);
 writeEP2(pat02_ADDR, 0b11110000, 0b11110000);
 writeEP2(pat03_ADDR, 0b11111000, 0b00000100);
 writeEP2(pat04_ADDR, 0b11001100, 0b11001100);
 writeEP2(pat05_ADDR, 0b10001000, 0b10001000);
 writeEP2(pat06_ADDR, 0b10101010, 0b10100000);
 writeEP2(pat07_ADDR, 0b10101010, 0b10101010);
 writeEP2(pat08_ADDR, 0b10100000, 0b10100000);
 writeEP2(pat09_ADDR, 0b11000000, 0b11000000);
 writeEP2(pat10_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat11_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat12_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat13_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat14_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat15_ADDR, 0b10000000, 0b10000000);
 writeEP2(pat16_ADDR, 0b10000000, 0b10000000);

 // Default patterns 17-32
 // Reserved, write full NULL
 writeEP2(pat17_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat18_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat19_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat20_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat21_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat22_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat23_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat24_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat25_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat26_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat27_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat28_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat29_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat30_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat31_ADDR, 0b00000000, 0b00000000);
 writeEP2(pat32_ADDR, 0b00000000, 0b00000000);
 
 // Default pattern - flight mode binds
 writeEP2(mbind01_ADDR, 0x00, 0x00);
 writeEP2(mbind02_ADDR, 0x01, 0x01);
 writeEP2(mbind03_ADDR, 0x02, 0x02);
 writeEP2(mbind04_ADDR, 0x03, 0x03);
 writeEP2(mbind05_ADDR, 0x04, 0x04);
 writeEP2(mbind06_ADDR, 0x05, 0x05);
 writeEP2(mbind07_ADDR, 0x06, 0x06);
 writeEP2(mbind08_ADDR, 0x07, 0x07);
 writeEP2(mbind09_ADDR, 0x08, 0x08);
 writeEP2(mbind10_ADDR, 0x09, 0x09);
 writeEP2(mbind11_ADDR, 0x0A, 0x0A);
 writeEP2(mbind12_ADDR, 0x0B, 0x0B);
 writeEP2(mbind13_ADDR, 0x0C, 0x0C);
 writeEP2(mbind14_ADDR, 0x0D, 0x0D);
 writeEP2(mbind15_ADDR, 0x0E, 0x0E);
 writeEP2(mbind16_ADDR, 0x0F, 0x0F);

 // Default locations of different output LEDs 
 writeEEPROM(LEFT_IO_ADDR, 8);
 writeEEPROM(RIGHT_IO_ADDR, 4);
 writeEEPROM(FRONT_IO_ADDR, 9);
 writeEEPROM(REAR_IO_ADDR, 10);
 writeEEPROM(FLASH_IO_ADDR, 0);      // Future extra flasher 
 writeEEPROM(LEDPIN_IO_ADDR, 13);    // HeartBeat LEDPIN, should be 13 




 // Write details for versioncheck to EEPROM
 writeEEPROM(21, CHK1);
 writeEEPROM(21, CHK2);
}
