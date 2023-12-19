
class EditShipReview extends React.Component {

    constructor(props) {
        super(props);
        this.state = {
            id: this.props.data.shipInfoId,
            name: this.props.data.name,
            imo: this.props.data.imo,
            type: this.props.data.type,
            flag: this.props.data.flag,
            dwt: this.props.data.dwt,
            length: this.props.data.length,
            grossTon: this.props.data.grossTon,
            beam: this.props.data.beam,
            draught: this.props.data.draught,
            photo: this.props.data.photo,
            buildYear: this.props.data.buildYear,
            owner: this.props.data.owner,
            manager: this.props.data.manager,
            vesselQualityValue: this.props.data.shipEvaluations[0].vesselQualityValue,
            crewPerformanceValue: this.props.data.shipEvaluations[0].crewPerformanceValue,
            crewAttitudeValue: this.props.data.shipEvaluations[0].crewAttitudeValue,
            fuelEfficiencyValue: this.props.data.shipEvaluations[0].fuelEfficiencyValue,
            safetyScoreValue: this.props.data.shipEvaluations[0].safetyScoreValue,
            saved: "",
            showConfirm: { display: "none" }
        };
        console.log(this.state.id);
    }

    submitChange = () => {
        var shipInfo = {
            id: this.state.id,
            name: this.state.name,
            imo: this.state.imo,
            type: this.state.type,
            flag: this.state.flag,
            dwt: this.state.dwt,
            length: this.state.length,
            grossTon: this.state.grossTon,
            beam: this.state.beam,
            draught: this.state.draught,
            photo: this.state.photo,
            buildYear: this.state.buildYear,
            owner: this.state.owner,
            manager: this.state.manager,
            vesselQualityValue: this.state.vesselQualityValue,
            crewPerformanceValue: this.state.crewPerformanceValue,
            crewAttitudeValue: this.state.crewAttitudeValue,
            fuelEfficiencyValue: this.state.fuelEfficiencyValue,
            safetyScoreValue: this.state.safetyScoreValue
        };

        console.log(shipInfo);

        $.ajax({
            url: ShipReviewsURL+"/"+this.state.id,
            type: "PUT",
            data: JSON.stringify(shipInfo),
            contentType: "application/json",
            success: function (data) {
                console.log(data);
                this.setState({ showConfirm: { display: "inherit" } });
            }.bind(this),
            error: function (event, request, settings) {
                console.log(settings);
                console.log(event);
                console.log(request);
            }
        });
    }

    render() {
        //var handleAddressChange = (newAddress) => {
        //    this.setState({ address: newAddress });
        //}
        var handleNameChange = (e) => {
            this.setState({ name: e.target.value });
        }
        var handleTypeChange = (e) => {
            this.setState({ type: e.target.value });
        }
        var handleImoChange = (e) => {
            this.setState({ imo: e.target.value });
        }

        var handleFlagChange = (e) => {
            this.setState({ flag: e.target.value });
        }

        var handleDwtChange = (e) => {
            this.setState({ dwt: e.target.value });
        }

        var handleLengthChange = (e) => {
            this.setState({ length: e.target.value });
        }

        var handleGrossTonChange = (e) => {
            this.setState({ grossTon: e.target.value });
        }

        var handleBeamChange = (e) => {
            this.setState({ beam: e.target.value });
        }

        var handleDraughtChange = (e) => {
            this.setState({ draught: e.target.value });
        }

        var handlePhotoChange = (e) => {
            this.setState({ photo: e.target.value });
        }

        var handleBuildYearChange = (e) => {
            this.setState({ buildYear: e.target.value });
        }

        var handleOwnerChange = (e) => {
            this.setState({ owner: e.target.value });
        }

        var handleManagerChange = (e) => {
            this.setState({ manager: e.target.value });
        }

        var handleVesselQualityValueChange = (e) => {
            this.setState({ vesselQualityValue: e.target.value });
        }

        var handleCrewPerformanceValueChange = (e) => {
            this.setState({ crewPerformanceValue: e.target.value });
        }

        var handleCrewAttitudeValueChange = (e) => {
            this.setState({ crewAttitudeValue: e.target.value });
        }

        var handleFuelEfficiencyValueChange = (e) => {
            this.setState({ fuelEfficiencyValue: e.target.value });
        }

        var handleSafetyScoreValueChange = (e) => {
            this.setState({ safetyScoreValue: e.target.value });
        }


        




        ////
        return (
            <div className="row" >
                <div className="col-md-9">
                    <fieldset>
                        <legend>{this.state.name}</legend>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtName">Name:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtName" className="form-control" value={this.state.name} onChange={handleNameChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtType">Type:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtType" className="form-control" value={this.state.type} onChange={handleTypeChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtImo">IMO:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtImo" className="form-control" value={this.state.imo} onChange={handleImoChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtFlag">Flag:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtFlag" className="form-control" value={this.state.flag} onChange={handleFlagChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtDwt">DWT:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtDwt" className="form-control" value={this.state.dwt} onChange={handleDwtChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtLength">Length:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtLength" className="form-control" value={this.state.length} onChange={handleLengthChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtGrossTon">Gross Ton:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtGrossTon" className="form-control" value={this.state.grossTon} onChange={handleGrossTonChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtBeam">Beam:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtBeam" className="form-control" value={this.state.beam} onChange={handleBeamChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtDraught">Draught:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtDraught" className="form-control" value={this.state.draught} onChange={handleDraughtChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtPhoto">Photo:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtPhoto" className="form-control" value={this.state.photo} onChange={handlePhotoChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtBuildYear">Build Year:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtBuildYear" className="form-control" value={this.state.buildYear} onChange={handleBuildYearChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtOwner">Owner:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtOwner" className="form-control" value={this.state.owner} onChange={handleOwnerChange} />
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtManager">Manager:</label>
                            </div>
                            <div className="col-md-10">
                                <input id="txtManager" className="form-control" value={this.state.manager} onChange={handleManagerChange} />
                            </div>
                        </div>

                     
                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtRating">Vessel Quality Value:</label>
                            </div>
                            <div className="col-md-10">
                                <select id="drpRating" className="form-control" value={this.state.vesselQualityValue} onChange={handleVesselQualityValueChange}>
                                    <option key="0" value="0">0</option>
                                    <option key="1" value="1">1</option>
                                    <option key="2" value="2">2</option>
                                    <option key="3" value="3">3</option>
                                    <option key="4" value="4">4</option>
                                    <option key="5" value="5">5</option>
                                </select>
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtRating">Crew Performance Value:</label>
                            </div>
                            <div className="col-md-10">
                                <select id="drpRating" className="form-control" value={this.state.crewPerformanceValue} onChange={handleCrewPerformanceValueChange}>
                                    <option key="0" value="0">0</option>
                                    <option key="1" value="1">1</option>
                                    <option key="2" value="2">2</option>
                                    <option key="3" value="3">3</option>
                                    <option key="4" value="4">4</option>
                                    <option key="5" value="5">5</option>
                                </select>
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtRating">Crew Attitude Value:</label>
                            </div>
                            <div className="col-md-10">
                                <select id="drpRating" className="form-control" value={this.state.crewAttitudeValue} onChange={handleCrewAttitudeValueChange}>
                                    <option key="0" value="0">0</option>
                                    <option key="1" value="1">1</option>
                                    <option key="2" value="2">2</option>
                                    <option key="3" value="3">3</option>
                                    <option key="4" value="4">4</option>
                                    <option key="5" value="5">5</option>
                                </select>
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtRating">Vessel FuelEfficiency Value:</label>
                            </div>
                            <div className="col-md-10">
                                <select id="drpRating" className="form-control" value={this.state.fuelEfficiencyValue} onChange={handleFuelEfficiencyValueChange}>
                                    <option key="0" value="0">0</option>
                                    <option key="1" value="1">1</option>
                                    <option key="2" value="2">2</option>
                                    <option key="3" value="3">3</option>
                                    <option key="4" value="4">4</option>
                                    <option key="5" value="5">5</option>
                                </select>
                            </div>
                        </div>

                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <label htmlFor="txtRating">Vessel SafetyScore Value:</label>
                            </div>
                            <div className="col-md-10">
                                <select id="drpRating" className="form-control" value={this.state.safetyScoreValue} onChange={handleSafetyScoreValueChange}>
                                    <option key="0" value="0">0</option>
                                    <option key="1" value="1">1</option>
                                    <option key="2" value="2">2</option>
                                    <option key="3" value="3">3</option>
                                    <option key="4" value="4">4</option>
                                    <option key="5" value="5">5</option>
                                </select>
                            </div>
                        </div>


                        <div className="row form-group">
                            <div className="col-md-2 label-align">
                                <button className="btn btn-primary" type="button" onClick={this.submitChange}>Save</button>
                            </div>
                            <div className="col-md-10" id="divConfirmation">
                                <span className="form-control alert-success" style={this.state.showConfirm}>Update saved</span>
                            </div>
                        </div>
                        <br></br>
                        <br></br>
                    </fieldset>
                </div>
            </div>
        );
    


    }
}