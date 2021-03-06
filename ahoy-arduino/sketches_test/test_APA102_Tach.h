#define APA102_CLOCK_PIN 13
#define APA102_DATA_PIN 11
#define MAX_LED_COUNT 100

#define ARDUINO_DEBUG
#include "../ahoy/systems/loopSystem.h"
#include "../ahoy/led/ledStripAPA102.h"
#include "../ahoy/led/ledController.h"

#include "../ahoy/sensors/hallTachometer.h"

HallTachometer *tach;

LedStripAPA102 *strip;
LedController *controller;

void setup()
{
	Serial.begin(115200);
#ifdef ARDUINO_DEBUG
	Serial.println();
	Serial.println("BEGIN TEST");
#endif
	tach = CreateHallTachometer(2);

	strip = new LedStripAPA102();
	// strip->leds[0].g = 255;
	controller = new LedController(strip, false);
	controller->segments[0]->ledIndexMax = 64;
	controller->segments[0]->posB = Vector3(0.5, 0, 0);
	controller->patterns[0]->speed = 0.1;
	controller->patterns[0]->colorA = Color(0, 255, 0);
	controller->patterns[0]->colorB = Color(0, 0, 255);
}

void loop()
{
	LoopSystem::Update(); //used to calculate delta time
	tach->Update();
	float frac = tach->fraction;
	// frac = (frac > 0.25 && frac < 0.75) ? 0.5 : 0;
	Color col = Color::FromHSV(frac);

	controller->patterns[0]->colorA = col;
	controller->patterns[0]->colorB = col;
	controller->Update();
}