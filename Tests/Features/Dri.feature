Feature: DRI

Simple endpoint for getting DRI (Dietary Reference Intake) values

@dri
Scenario: Fetch DRI values
	When I request the DRI data
	Then the response should contain 41 nutrients
